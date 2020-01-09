using Discussor.Core.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Discussor.Infrastructure.Identity
{
    public class User : IdentityUser
    {
        public virtual ICollection<Theme> Themes { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<Reply> Replies { get; set; }
    }
}
