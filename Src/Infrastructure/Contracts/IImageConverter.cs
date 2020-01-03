using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Contracts
{
    public interface IImageConverter
    {
        byte[] ConvertToByteArray(IFormFile image);
    }
}
