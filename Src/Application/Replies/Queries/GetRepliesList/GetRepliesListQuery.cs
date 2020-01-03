﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Replies.Queries.GetRepliesList
{
    public class GetRepliesListQuery : IRequest<RepliesListViewModel>
    {
        public int PostId { get; set; }
    }
}