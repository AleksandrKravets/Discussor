using MediatR;

namespace Discussor.Core.Application.Themes.Queries.GetThemesList
{
    public class GetThemesListQuery : IRequest<ThemesListViewModel>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}
