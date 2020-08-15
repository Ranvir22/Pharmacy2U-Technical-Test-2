using Microsoft.EntityFrameworkCore;
using Pharmacy2UTechnicalTest.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pharmacy2UTechnicalTest.Contexts
{
   public class P2UTechTestDbContext : DbContext
   {
      public P2UTechTestDbContext(DbContextOptions<P2UTechTestDbContext> options)
         : base(options)
      {
      }

      public virtual DbSet<User> Users { get; set; }

      public virtual DbSet<Currency> Currencies { get; set; }

      public virtual DbSet<ConversionRate> ConversionRates { get; set; }

      public virtual DbSet<ConversionLog> ConversionLogs { get; set; }

      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
         //Configure the table relationships
         modelBuilder.Entity<User>()
            .HasMany(u => u.ConversionLogs)
            .WithOne(l => l.User)
            .HasForeignKey(l => l.UserId);

         modelBuilder.Entity<ConversionRate>()
            .HasMany(r => r.ConversionLogs)
            .WithOne(l => l.ConversionRate)
            .HasForeignKey(l => l.ConversionRateId);

         modelBuilder.Entity<Currency>()
            .HasMany(c => c.ConversionRatesFrom)
            .WithOne(r => r.ConvertFrom)
            .HasForeignKey(r => r.ConvertFromId);

         modelBuilder.Entity<Currency>()
            .HasMany(c => c.ConversionRatesTo)
            .WithOne(r => r.ConvertTo)
            .HasForeignKey(r => r.ConvertToId);            
            
         base.OnModelCreating(modelBuilder);
      }
   }
}
