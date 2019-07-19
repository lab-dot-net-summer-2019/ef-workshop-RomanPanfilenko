using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SamuraiApp.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace SamuraiApp.Data.Mapping
{
    public class SamuraiSwordMap : IEntityTypeConfiguration<SamuraiSword>
    {
        public void Configure(EntityTypeBuilder<SamuraiSword> builder)
        {
            builder.HasKey(s => new { s.SamuraiId, s.SwordId });

            builder.HasOne(sb => sb.Sword)
                .WithMany(b => b.SamuraiSwords)
                .HasForeignKey(sb => new { sb.SwordId });

            builder.HasOne(sb => sb.Samurai)
                .WithMany(b => b.SamuraiSwords)
                .HasForeignKey(sb => new { sb.SamuraiId });
        }
    }
}
