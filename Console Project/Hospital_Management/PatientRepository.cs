using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Management
{
    public class PatientRepository : IPatientRepository
    {
        private readonly List<Patient> _patients = new();
        public void Add(Patient patient)
        {
            if(_patients.Any(p => p.Id == patient.Id))
            {
                throw new ArgumentException("Id already exists");
            }

            _patients.Add(patient);
        }

        public List<Patient> GetAllPatient()
        {
            return _patients.ToList();
        }

        public Patient GetPatientById(int id)
        {
          return _patients.FirstOrDefault( p => p.Id == id);
        }
    }
}
