using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models
{
    public class CreateThemeViewModel
    {
        public string Title { get; set; }
        public IFormFile Image { get; set; }
    }
}
