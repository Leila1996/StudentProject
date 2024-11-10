// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using StudentProject.Models;

//Student adel = new Student("Kis Adél",17);
Student adel = new Student
{
    Name = "Kis Adél",
    Age = 17,
};
Student janos = new Student
{
    Name = "Kis János",
    Age = 17,
};

Console.WriteLine(adel);
Console.WriteLine(janos);

if (Student.IsEqual(adel, janos))
    Console.WriteLine($"{adel.Name} adatai megegyeznek {janos.Name} adataival.");
else
    Console.WriteLine($"{adel.Name} adatai nem egyeznek meg {janos.Name} adataival.");

if (adel.IsYounger(janos))
    Console.WriteLine($"{adel.Name} fiatalabb mint {janos.Name}.");
else if (janos.IsYounger(adel))
    Console.WriteLine($"{janos.Name} fiatalabb mint {adel.Name}.");
else
    Console.WriteLine($"{janos.Name} és {adel.Name} egykorúak.");

ClassSecretary erno = new ClassSecretary();
int taskNumber = erno.GetNumberOfTasks();
Console.WriteLine(taskNumber);

List<string> feladatok = new List<string>() { "képviselet", "szavazás" };
ClassSecretary tibi = new ClassSecretary("Tibi",16,feladatok);
Console.WriteLine(tibi.GetNumberOfTasks());