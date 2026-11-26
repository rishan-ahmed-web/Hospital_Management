using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Management
{
    public class Doctor : Person
    {

        public string? Specalist { get; set; }
        public int Fees { get; private set; }

        public Doctor(string speacalist,int fees,int id, string? name, string? phone) 
            : base(id, name, phone)
        {
            Specalist = speacalist;
            if(fees > 0)
            Fees = fees;
            else
                Console.WriteLine("Fess must be positive");
        }
     
    }
}
