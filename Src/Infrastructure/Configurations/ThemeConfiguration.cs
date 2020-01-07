using Discussor.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Discussor.Infrastructure.Configurations
{
    internal class ThemeConfiguration : IEntityTypeConfiguration<Theme>
    {
        public void Configure(EntityTypeBuilder<Theme> builder)
        {
            builder.Property(p => p.Image)
                .HasColumnType("image")
                .IsRequired();

            builder.Property(p => p.DateOfCreation)
                .IsRequired();

            builder.Property(p => p.Title)
                .IsRequired()
                .HasMaxLength(150);
        }
    }
}
