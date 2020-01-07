using Discussor.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Discussor.Infrastructure.Configurations
{
    internal class ReplyConfiguration : IEntityTypeConfiguration<Reply>
    {
        public void Configure(EntityTypeBuilder<Reply> builder)
        {
            builder.Property(p => p.Content)
                .IsRequired()
                .HasMaxLength(10000);

            builder.Property(p => p.DateOfCreation)
                .IsRequired();
        }
    }
}
