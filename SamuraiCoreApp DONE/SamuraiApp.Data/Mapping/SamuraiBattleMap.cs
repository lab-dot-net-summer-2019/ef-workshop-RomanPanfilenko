using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SamuraiApp.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace SamuraiApp.Data.Mapping
{
    public class SamuraiBattleMap: IEntityTypeConfiguration<SamuraiBattle>
    {
        public void Configure(EntityTypeBuilder<SamuraiBattle> builder)
        {
            builder.HasKey(s => new { s.BattleId, s.SamuraiId });

            builder.HasOne(sb => sb.Battle)
                .WithMany(b => b.SamuraiBattles)
                .HasForeignKey(sb => new { sb.BattleId });

            builder.HasOne(sb => sb.Samurai)
                .WithMany(s => s.SamuraiBattles)
                .HasForeignKey(sb => new { sb.SamuraiId });

        }
    }
}
