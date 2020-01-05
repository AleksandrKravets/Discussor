using Application.Common.Exceptions;
using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Themes.Queries.GetTheme
{
    public class GetThemeQueryHandler : IRequestHandler<GetThemeQuery, ThemeViewModel>
    {
        private readonly IApplicationDbContext _context;

        public GetThemeQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ThemeViewModel> Handle(GetThemeQuery request, CancellationToken cancellationToken)
        {
            var theme = await _context.Themes.FirstOrDefaultAsync(theme => theme.Id == request.Id);

            if (theme == null)
                throw new NotFoundException(nameof(Theme), request.Id);

            var result = new ThemeViewModel
            {
                Id = theme.Id,
                Title = theme.Title,
                DateOfCreation = theme.DateOfCreation,
                Image = theme.Image
            };

            return result;
        }
    }
}
