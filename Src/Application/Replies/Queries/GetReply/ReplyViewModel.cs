﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Replies.Queries.GetReply
{
    public class ReplyViewModel
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime DateOfCreation { get; set; }
        public int PostId { get; set; }
    }
}
