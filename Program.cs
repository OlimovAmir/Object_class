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
        person1.FirsName = "Olimov";

        Adress adress = new Adress();

        adress.Country = "TJS";
        adress.Region = "Sugd";
        adress.City = "Khudjand";

        person1.Adress = adress;

        Console.WriteLine(person1);
    }
}
