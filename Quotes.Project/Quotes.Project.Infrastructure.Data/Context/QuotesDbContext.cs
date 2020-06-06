using Microsoft.EntityFrameworkCore;
using Quotes.Project.Domain.Model;

namespace Quotes.Project.Infrastructure.Data.Context
{
    public class QuotesDbContext : DbContext
    {
        public DbSet<Quote> Quote { get; set; }

        public QuotesDbContext(DbContextOptions<QuotesDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Write Fluent API configurations here

            //Property Configurations
            modelBuilder.Entity<Quote>().ToTable("TBQUOTE");
            modelBuilder.Entity<Quote>().HasKey(q => q.Id);
            modelBuilder.Entity<Quote>().Property(q => q.Id).HasColumnName("IDQUOTE").HasColumnType("int").IsRequired();
            modelBuilder.Entity<Quote>().Property(q => q.Title).HasColumnName("TITLEQUOTE").HasColumnType("varchar(150)").IsRequired();
            modelBuilder.Entity<Quote>().Property(q => q.Author).HasColumnName("AUTHORQUOTE").HasColumnType("varchar(150)").IsRequired();
            modelBuilder.Entity<Quote>().Property(q => q.Description).HasColumnName("DESCRIPTIONQUOTE").HasColumnType("varchar(max)").IsRequired();
            modelBuilder.Entity<Quote>().Property(q => q.CreatedAt).HasColumnName("CREATEDAT").HasColumnType("datetime").IsRequired();
        }
    }
}
