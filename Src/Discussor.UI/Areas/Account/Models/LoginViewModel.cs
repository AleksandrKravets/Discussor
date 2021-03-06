﻿using System.ComponentModel.DataAnnotations;

namespace Discussor.WebUI.Areas.Account.Models
{
    public class LoginViewModel
    {
        [Required]
        public string Login { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember")]
        public bool RememberMe { get; set; }
    }
}
