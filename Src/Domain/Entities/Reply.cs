using Domain.Common;
using System;

namespace Domain.Entities
{
    public class Reply : StoredEntity
    {
        public string Content { get; set; }
        public DateTime DateOfCreation { get; set; }

        public int PostId { get; set; }
        public virtual Post Post { get; set; }
        public string UserId { get; set; }
    }
}
