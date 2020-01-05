using Microsoft.AspNetCore.Http;

namespace Infrastructure.Contracts
{
    public interface IImageConverter
    {
        byte[] ConvertToByteArray(IFormFile image);
    }
}
