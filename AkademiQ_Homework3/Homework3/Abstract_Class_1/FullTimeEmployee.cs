using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_1
{
    public class FullTimeEmployee:Employee
    {
        private const double MonthlySalary = 25000;

        public FullTimeEmployee(string name, int workingHours) 
            : base(name, workingHours) {}

        public override double CalculateSalary()
        {
            return MonthlySalary;
        }
        public override void Info()
        {
            base.Info();
            Console.WriteLine("Employment Type: Full-Time ");
        }
    }
}
