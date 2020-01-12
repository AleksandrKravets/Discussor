using Discussor.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Discussor.Infrastructure.Configurations
{
    internal class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasMany(c => c.Posts).WithOne();
            builder.HasMany(c => c.Replies).WithOne();
            builder.HasMany(c => c.Themes).WithOne();
        }
    }
}
