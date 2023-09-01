using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VRBike.Models;

namespace VRBike.Data
{
    public class VRBikeContext : DbContext
    {
        public VRBikeContext (DbContextOptions<VRBikeContext> options)
            : base(options)
        {
        }

        public DbSet<VRBike.Models.Tour> Tours { get; set; } = default!;

        public DbSet<VRBike.Models.Bikeapp> Bikeapps { get; set; }

        public DbSet<VRBike.Models.Video> Videos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tour>().ToTable("Tour");
            modelBuilder.Entity<Video>().ToTable("Video");
            modelBuilder.Entity<Bikeapp>().ToTable("Bikeapp");
        }
    }
}
