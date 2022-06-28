using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Introduce();

            var employee = new Employee();
            employee.Name = "Daria";
            employee.Introduce();
            Console.WriteLine(employee.GetEmployeesInfo());

            var employee2 = new Employee("Julia", "QA Automation");
            Console.WriteLine(employee2.GetEmployeesInfo());
            Console.WriteLine();

            Console.WriteLine(employee2.ToString());
            var employee3 = new Employee("Julia", "QA Automation");
            var result = employee2.Equals(employee3) ? "Equal" : "Not equal";
            Console.WriteLine(result);
            result = employee2.Equals(employee) ? "Equal" : "Not equal";
            Console.WriteLine(result);

            Console.WriteLine(employee3.GetType());
            Console.ReadKey();
        }
    }
}
