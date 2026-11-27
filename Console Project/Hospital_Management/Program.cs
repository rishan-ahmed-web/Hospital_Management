

using Hospital_Management;

IPatientRepository repo = new PatientRepository();
repo.Add(new Patient(1, "Rahim", 26, "01502859636"));
repo.Add(new Patient(2, "Karim", 32, "01802259298"));

Console.WriteLine("=========All Patient===========");

foreach(var p in repo.GetAll())
{
    Console.WriteLine($"{p.Id} | {p.Name} | {p.Age} | {p.Phone} ");
}

var found = repo.GetById(1);
Console.WriteLine(found != null ? $"Found: {found.Name}" : "Not Found");

try
{
    repo.Add(new Patient(3, "Salam", 35, "01956461165"));
}
catch(ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}

var list = repo.GetAll();
list.Clear();
Console.WriteLine(repo.GetAll().Count);