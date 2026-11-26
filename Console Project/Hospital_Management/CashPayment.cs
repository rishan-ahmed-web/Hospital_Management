using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Management
{
    public class CashPayment : IPayable
    {
        public bool Pay(decimal amount)
        {
            Console.WriteLine($"Payment {amount} by Cash");
            return true;
        }
    }
}
