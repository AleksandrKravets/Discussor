﻿using Discussor.Core.Domain.Common;
using System;

namespace Discussor.Core.Domain.Entities
{
    public class Reply : StoredEntity
    {
        public string Content { get; set; }
        public DateTime DateOfCreation { get; set; }
        public int PostId { get; set; }
        public string CreatorId { get; set; }

        public virtual Post Post { get; set; }
        public virtual ApplicationUser Creator { get; set; }
    }
}
