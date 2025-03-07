using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_1
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public int WorkingHours { get; set; }

        public Employee(string name, int workingHours)
        {
            Name = name;
            WorkingHours = workingHours;
        }

        public abstract double CalculateSalary();

        public virtual void Info()
        {
            Console.WriteLine($"Name:{Name}, Working Hours:{WorkingHours}");
        }
    }
}
