using Discussor.Core.Application.Common.Contracts.Repositories;
using Discussor.Core.Domain.Entities;
using Discussor.Infrastructure.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Discussor.Infrastructure.Repositories
{
    public class ThemeRepository : IThemeRepository
    {
        private readonly IApplicationDbContext _context;

        public ThemeRepository(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Create(Theme theme)
        {
            await _context.Themes.AddAsync(theme);
            await _context.SaveChangesAsync();
            return theme.Id;
        }

        public async Task<bool> Delete(int themeId)
        {
            var theme = await _context.Themes.FindAsync(themeId);

            if (theme == null)
                return false;

            _context.Themes.Remove(theme);
            await _context.SaveChangesAsync();

            return true;
        }

        public IEnumerable<Theme> GetAllThemes()
        {
            return _context.Themes;
        }

        public async Task<Theme> GetThemeById(int themeId)
        {
            return await _context.Themes.FindAsync(themeId);
        }

        public async Task<bool> Update(Theme theme)
        {
            var themeToUpdate = await _context.Themes.FindAsync(theme.Id);

            if (themeToUpdate == null)
                return false;

            themeToUpdate.Title = theme.Title;
            themeToUpdate.DateOfCreation = DateTime.Now;

            await _context.SaveChangesAsync();

            return true;
        }
    }
}
