namespace  StartegyPattern.CompositePattern
{
    public class Employee : IOrganizationalUnit
    {
        public string Name { get; set; }
        public Employee(string name)
        {
            Name = name;
        }

        public void ShowDetails()
    {
        Console.WriteLine($"Employee: {Name}");
    }
    }
}