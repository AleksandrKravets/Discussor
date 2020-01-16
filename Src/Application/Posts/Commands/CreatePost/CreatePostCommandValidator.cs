using FluentValidation;

namespace Discussor.Core.Application.Posts.Commands.CreatePost
{
    public class CreatePostCommandValidator : AbstractValidator<CreatePostCommand>
    {
        public CreatePostCommandValidator()
        {
            RuleFor(x => x.Content).MaximumLength(10000);
            RuleFor(x => x.CreatorId).NotEmpty();
            RuleFor(x => x.Title).MaximumLength(300);
            RuleFor(x => x.ThemeId).GreaterThan(0);
        }
    }
}
