using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieShop.Entities;

namespace MovieShop.Data
{
    public class MoveShopDbContext: DbContext
    {
        public MoveShopDbContext(DbContextOptions<MoveShopDbContext> options) :base(options)
        {
            
        }

       

        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        override protected void OnModelCreating( ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>(GenreConfiguration);
            modelBuilder.Entity<Movie>(MovieConfiguration);
        }

        private void MovieConfiguration(EntityTypeBuilder<Movie> builder)
        {
            builder.ToTable("Movie");
            builder.HasKey(m => m.id);
            builder.HasIndex(m => m.Title).IsUnique(false);
            builder.Property(m => m.Title).HasMaxLength(256);
            builder.Property(m => m.Overview).HasMaxLength(4096);
            builder.Property(m => m.Tagline).HasMaxLength(512);
            builder.Property(m => m.HomePage).HasMaxLength(2084);
            builder.Property(m => m.ImdbUrl).HasMaxLength(2084);
            builder.Property(m => m.PosterUrl).HasMaxLength(2084);
            builder.Property(m => m.BackdropUrl).HasMaxLength(2084);
            builder.Property(m => m.OriginalLanguage).HasMaxLength(64);
            builder.Property(m => m.Price).HasColumnType("decimal(5, 2)");

        }

        private void GenreConfiguration(EntityTypeBuilder<Genre> builder)
        {
            builder.ToTable("Genre");
            builder.HasKey(g=>g.id);
            builder.Property(g => g.name).HasMaxLength(25);
           
        }
    }
}
