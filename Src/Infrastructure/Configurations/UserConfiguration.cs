using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Discussor.Infrastructure.Configurations
{
    internal class UserConfiguration : IEntityTypeConfiguration<Identity.User>
    {
        public void Configure(EntityTypeBuilder<Identity.User> builder)
        {
            builder.HasMany(c => c.Posts).WithOne();
            builder.HasMany(c => c.Replies).WithOne();
            builder.HasMany(c => c.Themes).WithOne();
        }
    }
}
