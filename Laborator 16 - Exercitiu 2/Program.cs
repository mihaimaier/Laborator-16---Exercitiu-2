using Laborator_16___Exercitiu_2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Laborator_16___Exercitiu_2
{
    class Program
    {
        static void Main(string[] args)
        {
            SeedTable();
            using VehicleManagementSystem context = new VehicleManagementSystem();

            //Afisati toate autovehiculele in ordine descrescatoare a anului de fabricatie.

            context.Vehicles.OrderByDescending(s => s.ManufactureYear).ToList().ForEach(s => Console.WriteLine(s));

            Console.WriteLine();

            // Suplimentar - Afisati autovehiculele grupate in functie de numele producatorului sub forma.

            var vehicles = context.Vehicles.Include(s => s.Manufacturer).Select(s => new { Id = s.Id, Name = s.Name, Series = s.ChassisSeries, ManufactureYear = s.ManufactureYear });
            vehicles.ToList().ForEach(s => Console.WriteLine(s));

            context.SaveChanges();
        }

        static void SeedTable()
        {
            using var ctx = new VehicleManagementSystem();

            if (ctx.Vehicles.Count() != 0 || ctx.Manufacturers.Count() != 0)
            {
                return;
            }

            ctx.Vehicles.Add(new Vehicle
            {
                Name = "BMW",
                ChassisSeries = "Series 1",
                ManufactureYear = 2015,
                Manufacturer = new Manufacturer
                {
                    Name = "BMW",
                    Address = "Herbert-Quandt-Allee, 93055 Regensburg, Germany",
                }
            });
            ctx.Vehicles.Add(new Vehicle
            {
                Name = "Mercedes Benz",
                ChassisSeries = "A‑CLASS",
                ManufactureYear = 2022,
                Manufacturer = new Manufacturer
                {
                    Name = "Mercedez Benz",
                    Address = "Kecskemét, Mercedes út 1, 6000 Hungary",
                }
            });
            ctx.Vehicles.Add(new Vehicle
            {
                Name = "Mazda",
                ChassisSeries = "3",
                ManufactureYear = 2021,
                Manufacturer = new Manufacturer
                {
                    Name = "Mazda",
                    Address = "Fuchu, Aki District, Hiroshima Prefecture, Japan",
                }
            });
            ctx.Vehicles.Add(new Vehicle
            {
                Name = "Ford",
                ChassisSeries = "Focus",
                ManufactureYear = 2019,
                Manufacturer = new Manufacturer
                {
                    Name = "General Motors",
                    Address = "2525 E Abram St, Arlington, TX 76010, United States",
                }
            });
            ctx.Vehicles.Add(new Vehicle
            {
                Name = "Lamborghini",
                ChassisSeries = "Aventador",
                ManufactureYear = 2022,
                Manufacturer = new Manufacturer
                {
                    Name = "Volkswagen Group",
                    Address = "Sant'Agata Bolognese, in Northern Italy",
                }
            });
            ctx.Vehicles.Add(new Vehicle
            {
                Name = "Ferrari",
                ChassisSeries = "468",
                ManufactureYear = 2021,
                Manufacturer = new Manufacturer
                {
                    Name = "FIAT Chrysler Automobiles (FCA)",
                    Address = "Maranello, Italy",
                }
            });
            ctx.SaveChanges();
        }
    }
}
