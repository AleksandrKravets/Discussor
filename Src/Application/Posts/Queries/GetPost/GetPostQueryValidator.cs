using FluentValidation;

namespace Discussor.Core.Application.Posts.Queries.GetPost
{
    public class GetPostQueryValidator : AbstractValidator<GetPostQuery>
    {
        public GetPostQueryValidator()
        {
            RuleFor(x => x.PostId).GreaterThan(0);
        }
    }
}
