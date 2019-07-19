using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SamuraiApp.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace SamuraiApp.Data.Mapping
{
    public class QuoteMap : IEntityTypeConfiguration<Quote>
    {
        public void Configure(EntityTypeBuilder<Quote> builder)
        {
            builder.HasOne(sb => sb.Samurai)
                .WithMany(b => b.Quotes)
                .HasForeignKey(sb => new { sb.SamuraiId });


        }
    }
}
