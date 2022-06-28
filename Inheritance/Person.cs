using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Person
    {
        public string Name { get; set; }
        public Person()
        {
            Name = "Tmp";
        }

        public Person(string name)
        {
            Name = name;
        }

        public void Introduce()
        {
            Console.WriteLine($"Hi! My name is {Name}\n");
        }
    }
}
