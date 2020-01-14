using Discussor.Core.Domain.Common;
using System;
using System.Collections.Generic;

namespace Discussor.Core.Domain.Entities
{
    public class Theme : StoredEntity
    {
        public string Title { get; set; }
        public DateTime DateOfCreation { get; set; }
        public byte[] Image { get; set; }
        public string CreatorId { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
        public virtual ApplicationUser Creator { get; set; }

        public Theme()
        {
            Posts = new HashSet<Post>();
        }
    }
}
