using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SamuraiApp.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace SamuraiApp.Data.Mapping
{
    public class SamuraiMap : IEntityTypeConfiguration<Samurai>
    {
        public void Configure(EntityTypeBuilder<Samurai> builder)
        {
            builder.HasOne(sb => sb.SecretIdentity)
                .WithOne(b => b.Samurai)
                .HasForeignKey<SecretIdentity>(sb => new { sb.SamuraiId });

        }
    }
}
