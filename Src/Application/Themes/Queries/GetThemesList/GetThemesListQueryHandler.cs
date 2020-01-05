using Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Themes.Queries.GetThemesList
{
    public class GetThemesListQueryHandler : IRequestHandler<GetThemesListQuery, ThemesListViewModel>
    {
        private readonly IApplicationDbContext _context;

        public GetThemesListQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ThemesListViewModel> Handle(GetThemesListQuery request, CancellationToken cancellationToken)
        {
            var themes = await _context.Themes
                .Select(theme => new ThemeDto
                {
                    Id = theme.Id,
                    Title = theme.Title,
                    DateOfCreation = theme.DateOfCreation,
                    Image = theme.Image,
                    PostsNumber = theme.Posts.Count()
                }).ToListAsync();

            var themesList = new ThemesListViewModel
            {
                Themes = themes
            };

            return themesList;
        }
    }
}
