using Microsoft.AspNetCore.Http;

namespace Discussor.WebUI.Models
{
    public class CreateThemeViewModel
    {
        public string Title { get; set; }
        public IFormFile Image { get; set; }
    }
}
