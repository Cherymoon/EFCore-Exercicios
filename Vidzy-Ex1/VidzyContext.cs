using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class VidzyContext : DbContext
    {
        public DbSet<Video> Videos { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public VidzyContext() : base()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VideoGenre>()
                .HasKey(k => new { k.VideoId, k.GenreId });

            modelBuilder.Entity<VideoGenre>()
                .HasOne(v => v.Video)
                .WithMany(vg => vg.VideoGenres)
                .HasForeignKey(f => f.VideoId);

            modelBuilder.Entity<VideoGenre>()
                .HasOne(g => g.Genre)
                .WithMany(vg => vg.VideoGenres)
                .HasForeignKey(fk => fk.GenreId);

            modelBuilder.Entity<Video>()
                .HasData(new Video(1, "Learn C#", DateTime.Parse("22/04/2020")));
            modelBuilder.Entity<Genre>()
                .HasData(new Genre(1, "Progamming"));
            modelBuilder.Entity<VideoGenre>()
                .HasData(new VideoGenre(1, 1));

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("server=.\\SQLExpress; Database=Vidzy; Trusted_Connection=true");
    }
}
