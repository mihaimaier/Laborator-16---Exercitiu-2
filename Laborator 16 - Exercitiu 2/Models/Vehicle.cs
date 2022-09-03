using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator_16___Exercitiu_2.Models
{
    class Vehicle
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ChassisSeries { get; set; }

        public int ManufactureYear { get; set; }

        public Manufacturer Manufacturer { get; set; }

        public Vehicle()
        {
            this.Id = Id;
        }

        public override string ToString() =>
        $"{Id} {Name} {ChassisSeries} {Manufacturer} {ManufactureYear}";
    }
}
