namespace Patterns.Example01
{
    public class University
    {
        public string Name {get; set;}
        public List<Department> Departments {get; set;}

        public University(string name)
        {
            Name = name;
            Departments = new List<Department>();
        }

        public void AddDepartment(Department department)
        {
            Departments.Add(department);
        }
    }
}