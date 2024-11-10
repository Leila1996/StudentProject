using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProject.Models
{
    public class Parent
    {
        public string Name { get; set; }
        public string Occupation { get; set; }
        public string RelationshipToStudent { get; set; }

        public Parent(string name, string occupation, string relationshipToStudent)
        {
            Name = name;
            Occupation = occupation;
            RelationshipToStudent = relationshipToStudent;
        }

        public override string ToString()
        {
            return $"{Name}, Foglalkozás: {Occupation}, Kapcsolat a diákkal: {RelationshipToStudent}";
        }
    }
}
