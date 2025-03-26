using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        List<IAnimal> animals = new List<IAnimal>
        {
            new Dog(),
            new Cat(),
            new Cow()
        };

        foreach(var animal in animals)
        {
            Console.WriteLine($"{animal.Name} makes sound:  {animal.MakeSound()}");
        }
    }
}