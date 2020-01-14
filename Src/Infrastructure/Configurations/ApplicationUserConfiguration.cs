using Discussor.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Discussor.Infrastructure.Configurations
{
    internal class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasMany(c => c.Posts).WithOne(c => c.Creator);
            builder.HasMany(c => c.Replies).WithOne(c => c.Creator);
            builder.HasMany(c => c.Themes).WithOne(c => c.Creator);
        }
    }
}
