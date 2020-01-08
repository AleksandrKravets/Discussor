using Discussor.Core.Domain.Entities;
using Discussor.Infrastructure.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Discussor.Infrastructure.Configurations
{
    internal class UserConfiguration : IEntityTypeConfiguration<UserIdentity>
    {
        public void Configure(EntityTypeBuilder<UserIdentity> builder)
        {
            builder.HasMany(c => c.Posts).WithOne();
            builder.HasMany(c => c.Replies).WithOne();
            builder.HasMany(c => c.Themes).WithOne();
        }
    }
}
