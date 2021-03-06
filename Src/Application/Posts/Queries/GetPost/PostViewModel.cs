﻿using System;
using System.Collections.Generic;

namespace Discussor.Core.Application.Posts.Queries.GetPost
{
    public class PostViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime DateOfCreation { get; set; }
        public int ThemeId { get; set; }

        public UserDto Creator { get; set; }
        public IEnumerable<ReplyDto> Replies { get; set; }
    }
}
