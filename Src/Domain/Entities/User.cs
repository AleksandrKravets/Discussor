using System.Collections.Generic;

namespace Discussor.Core.Domain.Entities
{
    public class User
    {
        public string Id { get; set; }
        public string Username { get; set; }

        public virtual IEnumerable<Theme> Themes { get; set; }
        public virtual IEnumerable<Post> Posts { get; set; }
        public virtual IEnumerable<Reply> Replies { get; set; }
    }
}
