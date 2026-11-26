using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Management
{
    public class Appointment
    {
        public int Id { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
        public DateTime DateTime { get; private set; }

        public Appointment(int id, Doctor doctor, Patient patient, DateTime dateTime)
        {
            Id = id;
            Doctor = doctor;
            Patient = patient;
            DateTime = dateTime;
        }

        public void ReSchedule(DateTime newDate) => DateTime = newDate;
    }
}
