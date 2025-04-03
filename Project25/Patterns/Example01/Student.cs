namespace Patterns.Example01
{
    public class Student
    {
        public string Name {get; set;}
        public void Learn(Teacher teacher)
        {
            Console.WriteLine($"{Name} is learning form {teacher.Name}.");
        }
    }
}