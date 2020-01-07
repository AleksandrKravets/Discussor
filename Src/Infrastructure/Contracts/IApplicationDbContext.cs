using Discussor.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Discussor.Infrastructure.Contracts
{
    public interface IApplicationDbContext
    {
        public DbSet<Theme> Themes { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Reply> PostReplies { get; set; }
        public DbSet<User> Users { get; set; }
        Task<int> SaveChangesAsync();
    }
}
