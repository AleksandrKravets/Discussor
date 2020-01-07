using Microsoft.AspNetCore.Identity;

namespace Discussor.Infrastructure.Identity
{
    public class UserIdentity : IdentityUser
    {
        public virtual IEnumerable<Theme> Themes { get; set; }
        public virtual IEnumerable<Post> Posts { get; set; }
        public virtual IEnumerable<Reply> Replies { get; set; }
    }
}
