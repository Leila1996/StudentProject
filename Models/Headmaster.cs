using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProject.Models
{
    public class Headmaster
    {
        public string Name { get; set; }
        public int YearsInPosition { get; set; }
        public string Vision { get; set; }

        public Headmaster(string name, int yearsInPosition, string vision)
        {
            Name = name;
            YearsInPosition = yearsInPosition;
            Vision = vision;
        }

        public override string ToString()
        {
            return $"{Name}, Évek az igazgatói poszton: {YearsInPosition}, Vízió: {Vision}";
        }
    }
}
