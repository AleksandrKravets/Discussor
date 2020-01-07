using Discussor.Core.Application.Common.Interfaces;
using Discussor.Core.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Discussor.Infrastructure.Repositories
{
    public class ThemeRepository : IThemeRepository
    {
        public Task<int> Create(Theme theme)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete(int themeId)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Theme>> GetAllThemes()
        {
            throw new System.NotImplementedException();
        }

        public Task<Theme> GetThemeById(int themeId)
        {
            throw new System.NotImplementedException();
        }

        public Task Update(Theme theme)
        {
            throw new System.NotImplementedException();
        }
    }
}
