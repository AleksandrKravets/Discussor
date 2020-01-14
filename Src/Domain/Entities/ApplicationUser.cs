using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Discussor.Core.Domain.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<Theme> Themes { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<Reply> Replies { get; set; }

        public ApplicationUser()
        {
            Themes = new HashSet<Theme>();
            Posts = new HashSet<Post>();
            Replies = new HashSet<Reply>();
        }
    }
}
