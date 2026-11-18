using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WpfApp1.model;

namespace WpfApp1.Database
{
    public class CarContext : DbContext
    {
        public CarContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<Car> Cars { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = CarDb.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(
                new Car { Brand = "Toyota", Model = "Corolla", DoorCount = 4 },
                new Car { Brand = "Honda", Model = "Civic", DoorCount = 4 },
                new Car { Brand = "Ford", Model = "Mustang", DoorCount = 2 }
            );  
        }   
    }
}
