using Discussor.Core.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Discussor.Core.Application.Common.Contracts.Repositories
{
    public interface IThemeRepository
    {
        Task<int> Create(Theme theme);
        Task<Theme> GetThemeById(int themeId);
        IEnumerable<Theme> GetAllThemes();
        Task<bool> Update(Theme theme);
        Task<bool> Delete(int themeId);
    }
}
