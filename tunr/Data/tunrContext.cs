using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tunr.Models;
using Microsoft.EntityFrameworkCore;

namespace tunr.Data
{
    public class tunrContext : DbContext
    {
        public tunrContext(DbContextOptions<tunrContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Mixtape> Mixtapes { get; set; }

        // Changing table names to singular
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mixtape>().ToTable("Mixtape");
            modelBuilder.Entity<User>().ToTable("User");
        }
    }
}
