using Discussor.Core.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Discussor.Core.Application.Common.Contracts.Services
{
    public interface IThemeService
    {
        Task<int> CreateAsync(Theme theme);
        Task<Theme> GetThemeByIdAsync(int themeId);
        IEnumerable<Theme> GetAllThemes();
        Task<bool> UpdateAsync(Theme theme);
        Task<bool> DeleteAsync(int themeId);
    }
}
