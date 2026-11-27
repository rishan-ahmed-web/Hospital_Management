using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Management
{
    public interface IPatientRepository
    {
        void Add(Patient patient);
        Patient GetPatientById(int id);
        List<Patient> GetAllPatient();
    }
}
