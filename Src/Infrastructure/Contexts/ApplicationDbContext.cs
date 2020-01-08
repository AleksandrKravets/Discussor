using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Discussor.Core.Domain.Entities;
using Discussor.Infrastructure.Identity;
using Discussor.Infrastructure.Contracts;
using System.Threading.Tasks;

namespace Infrastructure.Contexts
{
    internal class ApplicationDbContext : IdentityDbContext<UserIdentity>, IApplicationDbContext
    {
        public DbSet<Theme> Themes { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Reply> PostReplies { get; set; }
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
            base.OnModelCreating(builder);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }
    }
}
