using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Configurations
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.Property(p => p.DateOfCreation)
                .IsRequired();

            builder.Property(p => p.Title)
                .IsRequired()
                .HasMaxLength(300);

            builder.Property(p => p.Content)
                .IsRequired()
               .HasMaxLength(10000);
        }
    }
}
