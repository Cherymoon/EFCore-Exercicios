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
            modelBuilder.Entity<Video>()
                .HasOne(p => p.Genre)
                .WithMany(p => p.Videos);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("server=.\\SQLExpress; Database=Vidzy; Trusted_Connection=true");
    }
}
