using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_class
{
    public class Address
    {
        public string City { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            return $"\nCountry:\t{Country},\nRegion:\t{Region}, \nCity:\t{City}";
        }
    }
}
