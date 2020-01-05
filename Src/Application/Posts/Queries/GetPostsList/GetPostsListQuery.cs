﻿using MediatR;

namespace Application.Posts.Queries.GetPostsList
{
    public class GetPostsListQuery : IRequest<PostsListViewModel>
    {
        public int ThemeId { get; set; }
    }
}
