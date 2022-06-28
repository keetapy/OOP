using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Employee: Person
    {
        public string JobPosition { get; set; }

        public Employee(): base()
        {
            JobPosition = "no info";
        }

        public Employee(string name, string position): base(name)
        {
            JobPosition = position;
        }

        public string GetEmployeesInfo()
        {
            return $"Name: {Name}\nJob position: {JobPosition}";
        }

        public override string ToString()
        {
            return GetEmployeesInfo();
        }

        public override bool Equals(object employee)
        {
            if(!(employee is Employee))
            {
                return false;
            }

            return Name == (employee as Employee).Name && JobPosition == (employee as Employee).JobPosition;
        }
    }
}
