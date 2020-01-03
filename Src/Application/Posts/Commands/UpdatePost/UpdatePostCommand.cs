using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Posts.Commands.UpdatePost
{
    public class UpdatePostCommand : IRequest
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int ThemeId { get; set; } //
    }
}
