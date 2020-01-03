using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Posts.Queries.GetPostsList
{
    public class GetPostsListQuery : IRequest<PostsListViewModel>
    {
        public int ThemeId { get; set; }
    }
}
