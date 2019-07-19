using Microsoft.EntityFrameworkCore;
using SamuraiApp.Data.Mapping;
using SamuraiApp.Domain;

namespace SamuraiApp.Data
{
    public class SamuraiContext:DbContext
    {
        public SamuraiContext()
        {
        }

        public SamuraiContext(DbContextOptions<SamuraiContext> options)
            : base(options)
        { }
        

        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Battle> Battles { get; set; }
        public DbSet<Sword> Swords { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder
                .ApplyConfiguration(new SamuraiBattleMap())
                .ApplyConfiguration(new SamuraiMap())
                .ApplyConfiguration(new SamuraiSwordMap())
                .ApplyConfiguration(new QuoteMap());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(
                 @"Server=DESKTOP-NIIG3S3\SQLEXPRESS;Database=SamuraiAppDataCore;Trusted_Connection=True;");
        }
    }
}
