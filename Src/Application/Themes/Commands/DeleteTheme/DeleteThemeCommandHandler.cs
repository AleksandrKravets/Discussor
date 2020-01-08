using Discussor.Core.Application.Common.Contracts.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Discussor.Core.Application.Themes.Commands.DeleteTheme
{
    public class DeleteThemeCommandHandler : IRequestHandler<DeleteThemeCommand, bool>
    {
        private readonly IThemeService _themeService;

        public DeleteThemeCommandHandler(IThemeService themeService)
        {
            _themeService = themeService;
        }

        public async Task<bool> Handle(DeleteThemeCommand request, CancellationToken cancellationToken)
        {
            return await _themeService.DeleteAsync(request.ThemeId);
        }
    }
}
