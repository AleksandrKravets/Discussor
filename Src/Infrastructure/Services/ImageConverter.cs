using Infrastructure.Contracts;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Infrastructure.Services
{
    public class ImageConverter : IImageConverter
    {
        public byte[] ConvertToByteArray(IFormFile image)
        {
            byte[] result = null;

            using (var stream = new MemoryStream())
            {
                image.CopyTo(stream);
                result = stream.ToArray();
            }

            return result;
        }
    }
}
