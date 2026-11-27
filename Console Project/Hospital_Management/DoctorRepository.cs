using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Management
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly List<Doctor> _doctors = new();
        public void Add(Doctor doctor)
        {
            if(_doctors.Any(d => d.Id == doctor.Id))
            
              throw new ArgumentException($"Doctor with id {doctor.Id} already exists");

            _doctors.Add(doctor);
            

        }

        public List<Doctor> GetAll()
        {
           return _doctors.ToList();
        }

        public Doctor GetById(int id)
        {
            return _doctors.FirstOrDefault(d => d.Id == id);
        }
    }
}
