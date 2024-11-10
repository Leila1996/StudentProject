using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProject.Models
{
    public class Technician
    {
        public string Name { get; set; }
        public string AreaOfExpertise { get; set; }
        public bool IsOnCall { get; set; }

        public Technician(string name, string areaOfExpertise, bool isOnCall)
        {
            Name = name;
            AreaOfExpertise = areaOfExpertise;
            IsOnCall = isOnCall;
        }

        public override string ToString()
        {
            return $"{Name}, Szakirány: {AreaOfExpertise}, Készenlét: {IsOnCall}";
        }
    }
}
