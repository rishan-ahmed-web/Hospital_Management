using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Management
{
    public abstract class Person
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Phone { get; private set; }

        public Person(int id, string name, string phone)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Name is required",nameof(name));
            }
            if(string.IsNullOrWhiteSpace(phone))
            {
                throw new ArgumentException("Phone is required",nameof(phone));
            }

            Id = id;
            Name = name;
            Phone = phone;
     
        }
    }
}
