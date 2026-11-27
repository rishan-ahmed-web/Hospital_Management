using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Management
{
    public interface IDoctorRepository
    {
        void Add(Doctor doctor);
        Doctor GetById(int  id);
        List<Doctor> GetAll();

    }
}
