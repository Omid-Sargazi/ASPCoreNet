namespace Test.OOP
{
    public class MySQLDatabaseDI : IDatabase
    {
       public void SaveData(string data)
    {
        Console.WriteLine("Saving data to MySQL: " + data);
    }
    }
}