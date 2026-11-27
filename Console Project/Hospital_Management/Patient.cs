using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Management
{
    public class Patient : Person
    {
        public int Age { get; private set; }
        public Patient(int id, string name, int age, string phone) : base(id, name, phone)
        {
            if (age <= 0)
                throw new ArgumentException("Invalid Age", nameof(age));
             Age = age;
        }
    }
}
