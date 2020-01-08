﻿using Discussor.Core.Domain.Common;
using System;
using System.Collections.Generic;

namespace Discussor.Core.Domain.Entities
{
    public class Theme : StoredEntity
    {
        public string Title { get; set; }
        public DateTime DateOfCreation { get; set; }
        public byte[] Image { get; set; }

        public virtual IEnumerable<Post> Posts { get; set; }
        public string UserId { get; set; }
        //public User User { get; set; }
    }
}
