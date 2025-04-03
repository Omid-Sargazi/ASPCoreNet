namespace Patterns.Example01
{
    public class Department
    {
        public string Name {get; set;}
        public List<Professor> Professors { get; set; };

        public Department(string name)
        {
            Name = name;
            Professors = new List<Professor>();

        }
    }
}