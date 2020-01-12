using Discussor.Core.Domain.Entities;
using Discussor.Infrastructure.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Discussor.Infrastructure.Configurations
{
    internal class IdentityUserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(p => p.ApplicationUserId).IsRequired();
        }
    }
}
