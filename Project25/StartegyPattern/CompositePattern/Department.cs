namespace  StartegyPattern.CompositePattern
{
    public class Department : IOrganizationalUnit
    {
        private List<IOrganizationalUnit> employees = new List<IOrganizationalUnit>();

    public void Add(IOrganizationalUnit emp)
    {
        employees.Add(emp);
    }

    public void ShowDetails()
    {
        Console.WriteLine("Department Employees:");
        foreach (var emp in employees)
        {
            emp.ShowDetails();
        }
    }
    }
}