using FluentValidation;

namespace Discussor.Core.Application.Replies.Queries.GetRepliesList
{
    public class GetRepliesListQueryValidator : AbstractValidator<GetRepliesListQuery>
    {
        public GetRepliesListQueryValidator()
        {
            RuleFor(x => x.PostId).GreaterThan(0);
        }
    }
}
