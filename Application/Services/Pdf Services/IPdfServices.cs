using System;
using Application.DTOs;

namespace Application.Services.PdfServices
{
    public interface IPdfServices
    {
        byte[] GeneratePdf(List<CustomerDto> customers);

    }
}

