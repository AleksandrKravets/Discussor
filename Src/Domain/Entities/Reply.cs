using Discussor.Core.Domain.Common;
using System;

namespace Discussor.Core.Domain.Entities
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
