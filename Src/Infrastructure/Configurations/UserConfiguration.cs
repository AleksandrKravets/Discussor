using Infrastructure.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            //builder.HasMany(c => c.Posts)
            //    .WithOne(c => c.Author)
            //    .IsRequired()
            //    .OnDelete(DeleteBehavior.NoAction);

            //builder.HasMany(c => c.Replies)
            //    .WithOne(c => c.Author)
            //    .IsRequired()
            //    .OnDelete(DeleteBehavior.NoAction);

            //builder.HasMany(c => c.Themes)
            //    .WithOne(c => c.Creator)
            //    .IsRequired()
            //    .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
