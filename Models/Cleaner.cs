using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProject.Models
{
    public class Cleaner
    {
        public string Name { get; set; }
        public string AreaAssigned { get; set; }
        public int HoursWorked { get; set; }

        public Cleaner(string name, string areaAssigned, int hoursWorked)
        {
            Name = name;
            AreaAssigned = areaAssigned;
            HoursWorked = hoursWorked;
        }

        public override string ToString()
        {
            return $"{Name}, Kijelölt terület: {AreaAssigned}, Munkaórák: {HoursWorked}";
        }
    }
}
