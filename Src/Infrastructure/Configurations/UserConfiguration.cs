using Domain.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasMany(c => c.Posts)
                .WithOne(c => c.Creator)
                .IsRequired();

            builder.HasMany(c => c.Replies)
                .WithOne(c => c.Creator)
                .IsRequired();

            builder.HasMany(c => c.Themes)
                .WithOne(c => c.Creator)
                .IsRequired();
        }
    }
}
