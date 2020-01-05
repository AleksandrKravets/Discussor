using Domain.Common;
using Domain.Identity;
using System;

namespace Domain.Entities
{
    public class Reply : StoredEntity
    {
        public string Content { get; set; }
        public DateTime DateOfCreation { get; set; }

        public int PostId { get; set; }
        public virtual Post Post { get; set; }
        public int CreatorId { get; set; }
        public User Creator { get; set; }
    }
}
