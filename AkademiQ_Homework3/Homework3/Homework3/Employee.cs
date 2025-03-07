using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public int Salary { get; set; }
        public string Department { get; set; }

        public Employee(int ıd, string name, int salary, string department)
        {
            Id = ıd;
            Name = name;
            Salary = salary;
            Department = department;
        }

        public virtual double CalculateBonus()
        {
            return 0;
        }
        public virtual void Info()
        {
            Console.WriteLine($"Id:{Id}, Name:{Name}, Salary:{Salary}, Department:{Department}");
        }
    }
}
