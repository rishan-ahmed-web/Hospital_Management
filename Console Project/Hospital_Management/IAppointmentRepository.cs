using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Management
{
    public interface IAppointmentRepository
    {
        void Add(Appointment appointment);
        Appointment GetById(int  id);
        List<Appointment> GetAll();
        List<Appointment> GetByDoctor(int doctorId);
    }
}
