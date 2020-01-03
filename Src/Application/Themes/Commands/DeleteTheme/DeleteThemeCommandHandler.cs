using Application.Common.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Themes.Commands.DeleteTheme
{
    public class DeleteThemeCommandHandler : IRequestHandler<DeleteThemeCommand>
    {
        private readonly IApplicationDbContext _context;

        public DeleteThemeCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeleteThemeCommand request, CancellationToken cancellationToken)
        {
            var theme = await _context.Themes.FindAsync(request.ThemeId);

            _context.Themes.Remove(theme);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
