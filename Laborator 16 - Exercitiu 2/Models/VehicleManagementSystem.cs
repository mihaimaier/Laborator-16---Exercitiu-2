using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator_16___Exercitiu_2.Models
{
    class VehicleManagementSystem : DbContext
    {
        public DbSet<Vehicle> Vehicles { get; set; }

        public DbSet<Manufacturer> Manufacturers { get; set; }

        public VehicleManagementSystem(): base()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Iugkn\Desktop\C#.Net Course\Lab#16 - LINQ Cont, SQL, Entity Framework\Laborator 16 - Exercitiu 2\Laborator 16 - Exercitiu 2\VehicleManagementDatabase.mdf; Integrated Security = True");
        }
    }
}
