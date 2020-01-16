using FluentValidation;

namespace Discussor.Core.Application.Posts.Commands.UpdatePost
{
    public class UpdatePostCommandValidator : AbstractValidator<UpdatePostCommand>
    {
        public UpdatePostCommandValidator()
        {
            RuleFor(x => x.Content).MaximumLength(10000);
            RuleFor(x => x.Title).MaximumLength(300);
            RuleFor(x => x.ThemeId).GreaterThan(0);
            RuleFor(x => x.PostId).GreaterThan(0);
        }
    }
}
