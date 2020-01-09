﻿using Discussor.Core.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace Discussor.Infrastructure.Identity
{
    public class User : IdentityUser
    {
        public int ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
