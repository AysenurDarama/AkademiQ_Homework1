using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_1
{
    public class CreditCardPayment:IPayment
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Credit Card payment of {amount} processed.");
        }
    }
}
