namespace BlazorApp1.Data
{
    public class db_connection
    {
        public List<Student> students = new List<Student>()
        {
            new Student("Ivanov Ivan", 530),
            new Student("Petrov Petr",510),
            new Student("Sidorov Sergay",660)
        };
    }

    public class Student
    {
        public Student(string name, int group)
        {
            Id = Guid.NewGuid().ToString();

            Name = name;
            Group = group;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public int Group { get; set; }
    }
}
