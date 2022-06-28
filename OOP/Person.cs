using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person()
        {
            Name = "Tmp";
            Age = 1;
        }

        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public void Introduce()
        {
            Console.WriteLine($"Hi! My name is {Name}\n" +
                $"I'm {Age}");
        }

        public void GetAcquainted(Person newFriend)
        {
            Console.WriteLine($"Nice to meet you, {newFriend.Name}!");
        }
    }
}
