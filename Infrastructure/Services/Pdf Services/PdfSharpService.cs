using System.Reflection;
using Application.DTOs;
using Application.Services.PdfServices;
using PdfSharp.Drawing;
using PdfSharp.Fonts;
using PdfSharp.Pdf;

namespace Infrastructure.Services.Pdf_Services
{
    public class PdfSharpService : IPdfServices
    {
        public byte[] GeneratePdf(List<UserDto> users)
        {
            GlobalFontSettings.FontResolver = new FontResolver();
            // Create a new PDF document
            var document = new PdfDocument();
            document.Info.Title = "User List";

            // Create an empty page
            var page = document.AddPage();
            var gfx = XGraphics.FromPdfPage(page);

            // Use standard PDF fonts (Arial)
            var fontRegular = new XFont("Arial", 10, XFontStyleEx.Regular); // Use XFontStyle.Normal
            var fontBold = new XFont("Arial", 14, XFontStyleEx.Bold); // Bold font

            // Define the position for the text
            double yPoint = 40;

            // Draw the header
            gfx.DrawString("User List", fontBold, XBrushes.Black,
                new XRect(0, yPoint, page.Width, page.Height), XStringFormats.TopCenter);
            yPoint += 40;

            // Set column positions
            double nameColumnX = 150;
            double emailColumnX = 350;

            // Draw table headers
            gfx.DrawString("Name", fontRegular, XBrushes.Black,
                new XRect(nameColumnX, yPoint, page.Width, page.Height), XStringFormats.TopLeft);
            gfx.DrawString("Email", fontRegular, XBrushes.Black,
                new XRect(emailColumnX, yPoint, page.Width, page.Height), XStringFormats.TopLeft);
            yPoint += 20;

            // Draw a line under headers
            gfx.DrawLine(XPens.Black, 40, yPoint, page.Width - 40, yPoint);
            yPoint += 10;

            // Loop through users and draw each user's data
            foreach (var user in users)
            {
                gfx.DrawString(user.Name, fontRegular, XBrushes.Black,
                    new XRect(nameColumnX, yPoint, page.Width, page.Height), XStringFormats.TopLeft);
                gfx.DrawString(user.Email, fontRegular, XBrushes.Black,
                    new XRect(emailColumnX, yPoint, page.Width, page.Height), XStringFormats.TopLeft);
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
   

    public class FontResolver : IFontResolver
    {
        public string DefaultFontName => "Arial"; // You can change this to your preferred default font

        public byte[] GetFont(string faceName)
        {
            // Use embedded font resources
            if (faceName == "Arial")
            {
                return LoadFontData("Infrastructure.Assets.Fonts.Arial.ttf"); // Update with the correct path to your embedded font
            }
            if (faceName == "Arial_Bold")
            {
                return LoadFontData("Infrastructure.Assets.Fonts.Arial_Bold.ttf"); // Update with the correct path to your embedded font
            }
            throw new InvalidOperationException("Font not found");
        }

        public FontResolverInfo ResolveTypeface(string familyName, bool isBold, bool isItalic)
        {
            if (familyName.Equals("Arial", StringComparison.OrdinalIgnoreCase))
            {
                if (isBold)
                {
                    return new FontResolverInfo("Arial_Bold");
                }
                return new FontResolverInfo("Arial");
            }
            // Add support for other fonts if needed
            return null;
        }

        private byte[] LoadFontData(string resourceName)
        {
            var assembly = Assembly.GetExecutingAssembly();

            // Debugging - List available resources
            var resources = assembly.GetManifestResourceNames();
            foreach (var resource in resources)
            {
                Console.WriteLine(resource);
            }

            using (var stream = assembly.GetManifestResourceStream(resourceName))
            {
                if (stream == null)
                {
                    throw new InvalidOperationException($"Could not load font data from resource: {resourceName}");
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
