using System;
using System.Collections.Generic;
using System.Text;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace Docker.AutoDl.Database.SqLite
{
    public class SqLiteContext : DbContext
    {
        public DbSet<BlackListShowSqLite> BlackListShow { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BlackListShowSqLite>()
                .HasIndex(b => new { b.TraktShowId, b.Season })
                .IsUnique();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=AutoDl.db");
        }
    }
}
