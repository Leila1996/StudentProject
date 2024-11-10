using StudentProject.Models;
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        // Student példányosítás
        Student student1 = new Student("Kiss Péter", 2005, "peter.kiss@email.com", 06201234567);
        Student student2 = new Student("Nagy Anna", 2006, "nagy.anna@email.com", 06305723612);

        // Kiírjuk a diákok adatokat
        Console.WriteLine(student1.ToString());
        Console.WriteLine(student2.ToString());

        // Tanár példányosítás
        Teacher teacher1 = new Teacher("Dr. Smith", "Matematika", "smith@school.com");
        Teacher teacher2 = new Teacher("Kovács Eszter", "Biológia", "kovacs@school.com");
        

        // Kiírjuk a tanárok adatokat
        Console.WriteLine(teacher1.ToString());
        Console.WriteLine(teacher2.ToString());

        // Szülő példányosítás
        Parent parent1 = new Parent("Kiss László", "Üzletember", "Apuka");
        Parent parent2 = new Parent("Nagy Katalin", "Jogász", "Anya");

        // Kiírjuk a szülők adatokat
        Console.WriteLine(parent1.ToString());
        Console.WriteLine(parent2.ToString());

        // Adminisztrátor példányosítás
        Administrator admin1 = new Administrator("Tóth Beáta", "Titkárság", "Ügyintézés");
        Administrator admin2 = new Administrator("Szabó Péter", "Könyvelés", "Pénzügyi feladatok");

        // Kiírjuk az adminisztrátorok adatokat
        Console.WriteLine(admin1.ToString());
        Console.WriteLine(admin2.ToString());

        // Igazgató példányosítás
        Headmaster headmaster1 = new Headmaster("Bárány Zsuzsanna", 10, "Modern iskolai közösség építése");
        Headmaster headmaster2 = new Headmaster("Kovács Ádám", 15, "Személyre szabott oktatás");

        // Kiírjuk az igazgatók adatokat
        Console.WriteLine(headmaster1.ToString());
        Console.WriteLine(headmaster2.ToString());

        // Technikai dolgozó példányosítás
        Technician technician1 = new Technician("Papp Péter", "Informatikai támogatás", true);
        Technician technician2 = new Technician("Kiss Gábor", "Karbantartás", false);

        // Kiírjuk a technikai dolgozók adatokat
        Console.WriteLine(technician1.ToString());
        Console.WriteLine(technician2.ToString());

        // Portás példányosítás
        Doorman doorman1 = new Doorman("Lukács Ádám", "Nappali műszak", true);
        Doorman doorman2 = new Doorman("Molnár Mária", "Éjszakai műszak", false);

        // Kiírjuk a portások adatokat
        Console.WriteLine(doorman1.ToString());
        Console.WriteLine(doorman2.ToString());

        // Takarító példányosítás
        Cleaner cleaner1 = new Cleaner("Fekete László", "Irodák", 40);
        Cleaner cleaner2 = new Cleaner("Sárközi Anita", "Folyosók", 35);

        // Kiírjuk a takarítók adatokat
        Console.WriteLine(cleaner1.ToString());
        Console.WriteLine(cleaner2.ToString());
    }
}
