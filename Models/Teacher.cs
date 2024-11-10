
using System.Xml.Linq;

namespace StudentProject.Models
{
    public class Teacher
    {
        public string Name { get; set; }
        public string Subject { get; set; }
        public string Email { get; set; }

        public Teacher(string name, string subject, string email)
        {
            Name = name;
            Subject = subject;
            Email = email;
        }

        public override string ToString()
        {
            return $"Tanár: {Name}, Tantárgy: {Subject}, Email: {Email}";
        }
    }

}