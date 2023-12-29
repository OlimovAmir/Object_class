using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Object_class
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address? Address { get; set; }

        public override string ToString()
        {
            return $"Person: {FirstName} {LastName}, \nAddress: {Address}";
        }
    }
}
