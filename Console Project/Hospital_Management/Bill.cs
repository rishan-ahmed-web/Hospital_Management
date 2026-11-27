using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Management
{
    public class Bill
    {
        public decimal Amount { get; set; }
        public Bill(decimal amount)
        {
            Amount = amount;
        }

        public void Settle(IPayable Payment)
        {
            Payment.Pay(Amount);
        }
    }
}
