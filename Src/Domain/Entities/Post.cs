using Discussor.Core.Domain.Common;
using System;
using System.Collections.Generic;

namespace Discussor.Core.Domain.Entities
{
    public class Post : StoredEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime DateOfCreation { get; set; }

        public int ThemeId { get; set; }
        public virtual Theme Theme { get; set; }
        public virtual ICollection<Reply> Replies { get; set; }
        public string UserId { get; set; }

        public Post()
        {
            Replies = new HashSet<Reply>();
        }
    }
}
