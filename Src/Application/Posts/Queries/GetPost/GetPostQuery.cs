using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Posts.Queries.GetPost
{
    public class GetPostQuery : IRequest<PostViewModel>
    {
        public int PostId { get; set; }
    }
}
