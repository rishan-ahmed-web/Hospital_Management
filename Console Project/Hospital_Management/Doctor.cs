using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Management
{
    public class Doctor : Person
    {

        public string Specialty { get; set; }
        public decimal Fee { get; private set; }

        public Doctor(int id, string name, string specialty, decimal fee, string phone) 
            : base(id, name, phone)
        {
            if (string.IsNullOrWhiteSpace(specialty))
            {
                throw new ArgumentException("Specialty is required", nameof(specialty));
            }
          
            if (fee <= 0)
                throw new ArgumentException("Fee must be positive", nameof(fee));
            Specialty = specialty;
            Fee = fee;
        }
     
    }
}
