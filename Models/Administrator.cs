using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProject.Models
{
    public class Administrator
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public string TaskDescription { get; set; }

        public Administrator(string name, string department, string taskDescription)
        {
            Name = name;
            Department = department;
            TaskDescription = taskDescription;
        }

        public override string ToString()
        {
            return $"{Name}, Osztály: {Department}, Feladat: {TaskDescription}";
        }
    }
}
