using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Posts.Commands.DeletePost
{
    public class DeletePostCommand : IRequest
    {
        public int PostId { get; set; }
    }
}
