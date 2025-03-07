using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public class Developer:Employee
    {
        public string About { get; set; }
        public Developer(int ıd, string name, int salary, string department,string about)
            : base(ıd, name, salary, department)
        {
            About = about;
        }
        public override double CalculateBonus()
        {
            return Salary * 0.10;

        }
        public override void Info()
        {
            base.Info();
            Console.WriteLine($"About: {About}");
        }
    }
}
