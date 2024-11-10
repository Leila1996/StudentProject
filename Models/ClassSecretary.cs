namespace StudentProject.Models
{
    public class ClassSecretary : Student
    {
        List<string> tasks = new List<string>();

        public ClassSecretary()
        {
        }

        public ClassSecretary(string name, int age,string task)
        {
            tasks.Add(task);
            _name= name;
            _age= age;
        }

        public ClassSecretary(string name, int age,List<string> tasks)
        {
            this.tasks = tasks;
            _name= name;
            _age= age;
        }   

        public int GetNumberOfTasks()
        {
            return tasks.Count;
        }
    }
}
