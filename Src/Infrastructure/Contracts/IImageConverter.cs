using Microsoft.AspNetCore.Http;

namespace Discussor.Infrastructure.Contracts
{
    public interface IImageConverter
    {
        byte[] ConvertToByteArray(IFormFile image);
    }
}
