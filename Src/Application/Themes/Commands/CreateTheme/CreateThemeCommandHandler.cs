using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Themes.Commands.CreateTheme
{
    public class CreateThemeCommandHandler : IRequestHandler<CreateThemeCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public CreateThemeCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateThemeCommand request, CancellationToken cancellationToken)
        {
            var theme = new Theme
            {
                Title = request.Title,
                Image = request.Image,
                DateOfCreation = DateTime.Now
            };

            await _context.Themes.AddAsync(theme);

            await _context.SaveChangesAsync(cancellationToken);

            return theme.Id;
        }
    }
}
