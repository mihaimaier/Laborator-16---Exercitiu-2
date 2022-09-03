using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator_16___Exercitiu_2.Models
{
    class Manufacturer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public Manufacturer()
        {
            this.Id = Id;
        }

        public override string ToString() =>
            $"{Id} {Name} {Address}";
        
    }
}
