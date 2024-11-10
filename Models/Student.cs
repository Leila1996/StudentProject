namespace StudentProject.Models
{
    public class Student
    {
        protected string _name;
        protected int _age;
        protected string _email;
        protected int _phone;

        public Student()
        {
            _name= string.Empty;
            _age = 0;
            _email= string.Empty;
            _phone= 0;
        }


        public Student(string name, int age, string email, int phone)
        {
            _name = name;
            _age = age;
            _email = email;
            _phone = phone;
        }

        public string Name { get =>_name; set => _name=value; }
        public int Age { get =>_age; set=> _age=value; }

        public string Email { get =>_email; set => _email=value; }

        public int Phone { get =>_phone; set => _phone=value; }

        public static bool IsEqual(Student student, Student otherStudent)
        {
            if ((student.Name == otherStudent.Name) && (student.Age==otherStudent.Age) && (student.Email == otherStudent.Email) && (student.Phone == otherStudent.Phone))
                return true;
            else
                return false;
        }

        public bool IsYounger(Student otherStudent)
        {
            if (_age < otherStudent.Age)
                return true;
            return false;
        }
        public override string ToString()
        {
            return $"{_name} ({_age} éves) {_email} {_phone}";
        }
    }
}
