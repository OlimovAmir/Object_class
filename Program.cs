using Object_class;
using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Cat cat1 = new Cat();

        cat1.Age = 5;
        cat1.Name = "Barsic";

        Cat cat2 = new Cat
        {
            Age = 7,
            Name = "Murzik",
        };
        Person person1 = new Person();
        person1.LastName = "Amir";
        person1.FirstName = "Olimov";

        Address address = new Address();
        address.Country = "TJS";
        address.Region = "Sugd";
        address.City = "Khudjand";

        person1.Address = address;

        Console.WriteLine(person1);


        Person person2 = new Person 
        {
            FirstName = "Olimova",
            LastName = "Parvina",
            Address = new Address
            {
                Country = "Russia",
                City = "Moscow",
                Region = "RF",
            }
        };

        Console.WriteLine($"{person2}");
    }
}
