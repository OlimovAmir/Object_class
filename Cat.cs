using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_class
{
    internal class Cat
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Cat()
        {
            
        }

        public Cat(string name)
        {
           this.Name = name;
        }
    }
}
