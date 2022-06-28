using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Name = "Daria";
            person.Age = 20;

            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
            Console.WriteLine();

            var person2 = new Person();

            Console.WriteLine(person2.Name);
            Console.WriteLine(person2.Age);
            Console.WriteLine();

            var person3 = new Person();

            person3.Name = "Daria2";

            Console.WriteLine(person3.Name);
            Console.WriteLine(person3.Age);
            Console.WriteLine();

            var person4 = new Person("Daria3", 22);

            Console.WriteLine(person4.Name);
            Console.WriteLine(person4.Age);
            Console.WriteLine();

            var person5 = new Person("Daria4", 25);

            person5.Introduce();
            Console.WriteLine();

            person5.GetAcquainted(person);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
