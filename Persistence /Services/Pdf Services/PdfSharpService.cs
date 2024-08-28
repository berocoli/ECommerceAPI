using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Fonts;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using Application.Services.PdfServices;
using Application.DTOs;

namespace Persistence.Services.Pdf_Services
{
    public class PdfSharpService : IPdfServices
    {
        public byte[] GeneratePdf(List<UserDto> users)
        {
            // Set a custom font resolver to embed fonts
            GlobalFontSettings.FontResolver = new CustomFontResolver();

            // Create a new PDF document
            var document = new PdfDocument();
            document.Info.Title = "User List";

            // Create an empty page
            var page = document.AddPage();
            var gfx = XGraphics.FromPdfPage(page);

            var fontRegular = new XFont("Arial", 10, XFontStyleEx.Regular);
            var fontBold = new XFont("Arial", 14, XFontStyleEx.Bold);

            // Define the position for the text
            double yPoint = 40;

            // Draw the header
            gfx.DrawString("User List", fontBold, XBrushes.Black, new XRect(0, yPoint, page.Width, page.Height), XStringFormats.TopCenter);
            yPoint += 40;

            // Set column positions
            double idColumnX = 40;
            double nameColumnX = 150;
            double emailColumnX = 350;

            // Draw table headers
            gfx.DrawString("Name", fontRegular, XBrushes.Black, new XRect(nameColumnX, yPoint, page.Width, page.Height), XStringFormats.TopLeft);
            gfx.DrawString("Email", fontRegular, XBrushes.Black, new XRect(emailColumnX, yPoint, page.Width, page.Height), XStringFormats.TopLeft);
            yPoint += 20;

            // Draw a line under headers
            gfx.DrawLine(XPens.Black, idColumnX, yPoint, page.Width - 40, yPoint);
            yPoint += 10;

            // Loop through users and draw each user's data
            foreach (var user in users)
            {
                gfx.DrawString(user.Name, fontRegular, XBrushes.Black, new XRect(nameColumnX, yPoint, page.Width, page.Height), XStringFormats.TopLeft);
                gfx.DrawString(user.Email, fontRegular, XBrushes.Black, new XRect(emailColumnX, yPoint, page.Width, page.Height), XStringFormats.TopLeft);
                yPoint += 20;

                // Add a new page if needed
                if (yPoint > page.Height - 40)
                {
                    page = document.AddPage();
                    gfx = XGraphics.FromPdfPage(page);
                    yPoint = 40;
                }
            }

            // Save the document to a byte array
            using (var stream = new MemoryStream())
            {
                document.Save(stream, false);
                return stream.ToArray();
            }
        }
    }
    public class CustomFontResolver : IFontResolver
    {
        public string DefaultFontName => "Arial";

        public byte[] GetFont(string faceName)
        {
            // Use embedded font resources
            if (faceName == "Arial#")
            {
                return LoadFontData("Persistance.Assets.Fonts.Arial.ttf"); // Update with correct path
            }
            if (faceName == "Arial#Bold")
            {
                return LoadFontData("Persistance.Assets.Fonts.Arial_Bold.ttf"); // Update with correct path
            }
            throw new InvalidOperationException("Font not found");
        }

        public FontResolverInfo ResolveTypeface(string familyName, bool isBold, bool isItalic)
        {
            if (familyName.Equals("Arial", StringComparison.OrdinalIgnoreCase))
            {
                if (isBold)
                {
                    return new FontResolverInfo("Arial#Bold");
                }
                return new FontResolverInfo("Arial#");
            }
            return null;
        }

        private byte[] LoadFontData(string resourceName)
        {
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
            {
                if (stream == null)
                {
                    throw new InvalidOperationException("Could not load font data");
                }
                using (var ms = new MemoryStream())
                {
                    stream.CopyTo(ms);
                    return ms.ToArray();
                }
            }
        }
    }
}