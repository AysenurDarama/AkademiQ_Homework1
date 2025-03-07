using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public class Manager:Employee
    {
        public int TeamSize { get; set; }
        public Manager(int ıd, string name, int salary, string department,int teamSize) 
            : base(ıd, name, salary, department)
        {
             TeamSize = teamSize;
        }
        public override double CalculateBonus()
        {
            return Salary * 0.20;
        }
        public override void Info()
        {
            base.Info();
            Console.WriteLine($"Team size: {TeamSize}");
        }

    }
}
