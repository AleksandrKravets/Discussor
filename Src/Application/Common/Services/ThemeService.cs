using Discussor.Core.Application.Common.Contracts.Repositories;
using Discussor.Core.Application.Common.Contracts.Services;
using Discussor.Core.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Discussor.Core.Application.Common.Services
{
    public class ThemeService : IThemeService
    {
        private readonly IThemeRepository _themeRepository;

        public ThemeService(IThemeRepository themeRepository)
        {
            _themeRepository = themeRepository;
        }

        public async Task<int> CreateAsync(Theme theme)
        {
            return await _themeRepository.Create(theme);
        }

        public async Task<bool> DeleteAsync(int themeId)
        {
            return await _themeRepository.Delete(themeId);
        }

        public IEnumerable<Theme> GetAllThemes()
        {
            return _themeRepository.GetAllThemes()
                .OrderByDescending(theme => theme.DateOfCreation)
                .ToList();
        }

        public async Task<Theme> GetThemeByIdAsync(int themeId)
        {
            return await _themeRepository.GetThemeById(themeId);
        }

        public async Task<bool> UpdateAsync(Theme theme)
        {
            return await _themeRepository.Update(theme);
        }

        public IEnumerable<Theme> GetThemesByPageNumber(int pageNumber, int pageSize)
        {
            return _themeRepository.GetAllThemes()
                .OrderByDescending(theme => theme.DateOfCreation)
                .Skip(pageSize * (pageNumber - 1))
                .Take(pageSize)
                .ToList();
        }

        public int GetThemesNumber()
        {
            return _themeRepository.GetAllThemes().Count();
        }
    }
}
