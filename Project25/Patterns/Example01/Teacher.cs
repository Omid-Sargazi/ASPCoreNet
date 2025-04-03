namespace Patterns.Example01
{
    public class Teacher
    {
        public string Name {get; set;}
        public void Teach(Student student)
        {
            Console.WriteLine($"{Name} is teaching {student.Name}");
        }
    }
}