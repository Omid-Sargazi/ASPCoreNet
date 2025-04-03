    namespace Patterns.Example01
{
    public class Professor
    {
        public string Name;
        public void Teach(Department department)
        {
            Console.WriteLine($"{Name} is teaching in {department.Name}.");
        }
    }
}