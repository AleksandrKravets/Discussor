using Discussor.Core.Domain.Entities;
using Discussor.Infrastructure.Identity;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Discussor.Infrastructure.Contracts
{
    public interface IApplicationDbContext
    {
        public DbSet<Theme> Themes { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Reply> PostReplies { get; set; }
        public DbSet<UserIdentity> Users { get; set; }
        Task<int> SaveChangesAsync();
    }
}
