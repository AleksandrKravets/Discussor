using FluentValidation;

namespace Discussor.Core.Application.Themes.Commands.CreateTheme
{
    public class CreateThemeCommandValidator : AbstractValidator<CreateThemeCommand>
    {
        public CreateThemeCommandValidator()
        {
            RuleFor(x => x.CreatorId).NotEmpty();
            RuleFor(x => x.Image).NotEmpty().NotNull();
            RuleFor(x => x.Title).MaximumLength(300);
        }
    }
}
