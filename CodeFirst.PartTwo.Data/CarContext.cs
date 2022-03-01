using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirst.PartTwo.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.PartTwo.Data
{
    public class CarContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Engine> Engines { get; set; }
        public DbSet<EngineType> EngineTypes { get; set; }

        public CarContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>()
                .HasOne(b => b.Engine)
                .WithOne(i => i.Car)
                .HasForeignKey<Engine>(b => b.Id);
        }
    }
}
