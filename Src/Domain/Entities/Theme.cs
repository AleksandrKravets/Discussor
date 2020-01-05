using Domain.Common;
using Domain.Identity;
using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Theme : StoredEntity
    {
        public string Title { get; set; }
        public DateTime DateOfCreation { get; set; }
        public byte[] Image { get; set; }

        public virtual IEnumerable<Post> Posts { get; set; }
        public int CreatorId { get; set; }
        public User Creator { get; set; }
    }
}
