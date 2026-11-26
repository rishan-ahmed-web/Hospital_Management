using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Management
{
    public class BKashPayment : IPayable
    {
        public bool Pay(decimal amount)
        {
            Console.WriteLine($"Payment {amount} by Bkash");
            return true;
        }
    }
}
