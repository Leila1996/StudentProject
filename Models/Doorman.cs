using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProject.Models
{
    public class Doorman
    {
        public string Name { get; set; }
        public string Shift { get; set; }
        public bool IsOnDuty { get; set; }

        public Doorman(string name, string shift, bool isOnDuty)
        {
            Name = name;
            Shift = shift;
            IsOnDuty = isOnDuty;
        }

        public override string ToString()
        {
            return $"{Name}, Műszak: {Shift}, Ügyelet: {IsOnDuty}";
        }
    }

}
