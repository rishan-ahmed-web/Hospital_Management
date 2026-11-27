

using Hospital_Management;
using System.Xml;

IPatientRepository repo = new PatientRepository();
repo.Add(new Patient(1, "Rahim", 26, "01502859636"));
repo.Add(new Patient(2, "Karim", 32, "01802259298"));

Console.WriteLine("=========All Patient===========");

foreach(var p in repo.GetAllPatient())
{
    Console.WriteLine($"{p.Id} | {p.Name} | {p.Age} | {p.Phone} ");
}

var found = repo.GetPatientById(1);
Console.WriteLine(found != null ? $"Found: {found.Name}" : "Not Found");

try
{
    repo.Add(new Patient(3, "Salam", 35, "01956461165"));
}
catch(ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}

var list = repo.GetAllPatient();
list.Clear();
Console.WriteLine(repo.GetAllPatient().Count);

Console.WriteLine("");

IDoctorRepository doctorRepo = new DoctorRepository();
doctorRepo.Add(new Doctor(101, "DR.Anis", "Psychoartist", 1000, "01865413146"));
doctorRepo.Add(new Doctor(102, "DR.Rubuya", "Guyni", 1000, "01885963214"));

foreach(var d in doctorRepo.GetAll())
{
    Console.WriteLine($"{d.Id} | {d.Name} | {d.Specialty} | {d.Fee} | {d.Phone} ");
}

var foundDoctor = doctorRepo.GetById(102);
Console.WriteLine(foundDoctor != null ? $"Found Doctor: {foundDoctor.Name}" : "Not Found");

try
{
    doctorRepo.Add(new Doctor(103, "DR.Fahad", "Sex", -1000, "01965324178"));
}
catch(ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}

var doctorList = doctorRepo.GetAll();
doctorList.Clear();
Console.WriteLine(doctorRepo.GetAll().Count);

Console.WriteLine("");

var a1 = new Appointment(1,doctorRepo.GetById(101),repo.GetPatientById(1),DateTime.Now.AddDays(1));
Console.WriteLine($"Appointment Status : {a1.Status}");

a1.Cancel();
Console.WriteLine($"Appointment Status: {a1.Status}");

try { a1.Cancel(); }
catch(InvalidOperationException ex) { Console.WriteLine(ex.Message); }

Console.WriteLine("");

try { a1.Complete(); }
catch(InvalidOperationException ex) { Console.WriteLine(ex.Message); }

try {
    new Appointment(2, doctorRepo.GetById(102), repo.GetPatientById(2), DateTime.Now.AddDays(-1));
}
catch(ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
Console.WriteLine("");

var a2 = new Appointment(3,doctorRepo.GetById(101),repo.GetPatientById(2),DateTime.Now.AddDays(1));
a2.Complete();
Console.WriteLine($"Appointment Status : {a2.Status}");

try
{
    a2.Cancel();
}
catch(InvalidOperationException ex) { Console.WriteLine(ex.Message); }

try { a2.ReSchedule(DateTime.Now.AddDays(2)); }
catch(InvalidOperationException ex) { Console.WriteLine(ex.Message); }