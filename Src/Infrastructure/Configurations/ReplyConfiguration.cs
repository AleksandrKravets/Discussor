using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class ReplyConfiguration : IEntityTypeConfiguration<Reply>
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
