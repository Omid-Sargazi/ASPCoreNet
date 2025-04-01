namespace Test.OOP
{
    public class DataManager
    {
        private MySQLDatabase _database = new MySQLDatabase();
        public void Save(string data)
    {
        database.SaveData(data);
    }
    }
}