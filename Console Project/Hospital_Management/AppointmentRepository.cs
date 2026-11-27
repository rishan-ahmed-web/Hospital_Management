using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Management
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly List<Appointment> _appointment = new();
        public void Add(Appointment appointment)
        {
            if(_appointment.Any(a => a.Id == appointment.Id))
            {
                throw new ArgumentException($"Appointment With id {appointment.Id} already exists");
            }
            _appointment.Add(appointment);
        }

        public List<Appointment> GetAll()
        {
            return _appointment.ToList();
        }

        public List<Appointment> GetByDoctor(int doctorId)
        {
          return _appointment.Where(a => a.Doctor.Id == doctorId).ToList();
        }

        public Appointment GetById(int id)
        {
            return _appointment.FirstOrDefault(a => a.Id == id);
        }
    }
}
