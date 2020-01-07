using Discussor.Infrastructure.Contracts;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace Discussor.Infrastructure.Services
{
    internal class ImageConverter : IImageConverter
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
