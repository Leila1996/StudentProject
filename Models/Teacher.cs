
using System.Xml.Linq;

namespace StudentProject.Models
{
    public class Teacher
    {
        public string Name { get; set; }
        public string Subject { get; set; }
        public int ExperienceYears { get; set; }
        public bool IsHeadOfDepartment { get; set; }
    }

        public Teacher(string name, string subject, int experienceYears, bool isHeadOfDepartment)
        {
            Name = name;
            Subject = subject;
            ExperienceYears = experienceYears;
            IsHeadOfDepartment = isHeadOfDepartment;
        }
        public override string ToString()
        {
            return $"{Name}, Tantárgy: {Subject}, Tapasztalat: {ExperienceYears} év, Tanszékvezető: {(IsHeadOfDepartment ? "Igen" : "Nem")}";
        }
}