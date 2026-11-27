using System;
using System.Collections.Generic;
using System.Text;

public enum AppointmentStatus { Booked, Cancelled, Completed };

namespace Hospital_Management
{
    public class Appointment
    {
        public int Id { get; }
        public Doctor Doctor { get; }
        public Patient Patient { get; }
        public DateTime Date { get; private set; }
        public AppointmentStatus Status { get; private set; }

        public Appointment(int id, Doctor doctor, Patient patient, DateTime date)
        {
            if(doctor == null)
                throw new ArgumentException("Doctor is required",nameof(doctor));

            if (patient == null)
                throw new ArgumentException("Patient is required", nameof(patient));

            if (date < DateTime.Now)
                throw new ArgumentException("Invalid Date Time", nameof(date));



            Id = id;
            Doctor = doctor;
            Patient = patient;
            Date = date;
            Status = AppointmentStatus.Booked;
        }

        public void Cancel()
        {
            if(Status != AppointmentStatus.Booked)
            {
                throw new InvalidOperationException($"Cannot cancel a {Status} appointment");
            }

            Status = AppointmentStatus.Cancelled;
        }

        public void Complete()
        {
            if(Status != AppointmentStatus.Booked)
            {
                throw new InvalidOperationException("Only booked appointment can be completed");
            }
           
             Status = AppointmentStatus.Completed;
        }

        public void ReSchedule(DateTime newDate)
        {
            if (Status != AppointmentStatus.Booked)
                throw new InvalidOperationException("Only booked appintment can be reschedule");

            if(newDate < DateTime.Now) 
                throw new ArgumentException("New date cannot be in the past",nameof(newDate));

            Date = newDate;
        }

  

        
    }
}
