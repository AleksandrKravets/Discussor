using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        public DbSet<Theme> Themes { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Reply> PostReplies { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
