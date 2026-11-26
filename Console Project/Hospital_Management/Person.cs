using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Management
{
    public abstract class Person
    {
        public int Id { get; private set; }
        public string? Name { get; private set; }
        public string? Phone { get; private set; }

        public Person(int id, string? name, string? phone)
        {
            Id = id;
            Name = name;
            if(phone.Length == 11)
            Phone = phone;
            else
                Console.WriteLine("Phone number must be 11 digit");
        }
    }
}
