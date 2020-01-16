using FluentValidation;

namespace Discussor.Core.Application.Themes.Commands.DeleteTheme
{
    public class DeleteThemeCommandValidator : AbstractValidator<DeleteThemeCommand>
    {
        public DeleteThemeCommandValidator()
        {
            RuleFor(x => x.ThemeId).GreaterThan(0);
        }
    }
}
