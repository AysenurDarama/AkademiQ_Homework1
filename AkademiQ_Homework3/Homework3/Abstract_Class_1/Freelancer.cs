using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_1
{
    public class Freelancer:Employee
    {
        private const double HourlyRate = 100;

        public Freelancer(string name, int workingHours) 
            : base(name, workingHours){}

        public override double CalculateSalary()
        {
            return HourlyRate * WorkingHours;
        }

        public override void Info()
        {
            base.Info();
            Console.WriteLine("Employment Type: Freelancer");
        }

    }
}
