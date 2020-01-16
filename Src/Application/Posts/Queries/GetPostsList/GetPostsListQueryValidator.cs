using FluentValidation;

namespace Discussor.Core.Application.Posts.Queries.GetPostsList
{
    public class GetPostsListQueryValidator : AbstractValidator<GetPostsListQuery>
    {
        public GetPostsListQueryValidator()
        {
            RuleFor(x => x.ThemeId).GreaterThan(0);
        }
    }
}
