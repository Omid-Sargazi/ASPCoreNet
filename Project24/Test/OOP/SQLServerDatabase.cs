namespace Test.OOP
{
    public class SQLServerDatabase:IDatabase
    {
        public void SaveData(string data)
    {
        Console.WriteLine("Saving data to SQL Server: " + data);
    }
    }
}