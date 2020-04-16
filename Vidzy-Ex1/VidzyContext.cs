using ConsoleApp5.Migrations;
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

            //VIDEO
            modelBuilder.Entity<Video>()
                .HasOne(p => p.Genre)
                .WithMany(p => p.Videos)
                .HasForeignKey(p => p.GenreId);


            modelBuilder.Entity<Video>()
                .Property(p => p.GenreId)
                .HasColumnName("GeneroID");

            modelBuilder.Entity<Video>()
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(255);
              
            modelBuilder.Entity<Video>()
                .Property(p => p.Classification)
                .HasColumnType("tinyint");

            //GENERO
            modelBuilder.Entity<Genre>()
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(255);

            //VIDEOTAG

            modelBuilder.Entity<VideoTags>()
                .HasKey(k => new { k.VideoId, k.TagId });

            modelBuilder.Entity<VideoTags>()
                .HasOne(v => v.Video)
                .WithMany(t => t.VideoTags)
                .HasForeignKey(fk => fk.VideoId);

            modelBuilder.Entity<VideoTags>()
                .HasOne(t => t.Tag)
                .WithMany(v => v.VideoTags)
                .HasForeignKey(fk => fk.TagId);



        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("server=.\\SQLExpress; Database=Vidzy; Trusted_Connection=true");
    }
}
