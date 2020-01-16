using FluentValidation;

namespace Discussor.Core.Application.Themes.Queries.GetTheme
{
    public class GetThemeQueryValidator : AbstractValidator<GetThemeQuery>
    {
        public GetThemeQueryValidator()
        {
            RuleFor(x => x.ThemeId).GreaterThan(0);
        }
    }
}
