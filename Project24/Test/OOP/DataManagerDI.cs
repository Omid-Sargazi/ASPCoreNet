namespace Test.OOP
{   
    public class DataManagerDI
    {
            private readonly IDatabase _database;
            public DataManagerDI(IDatabase database)
            {
                _database = database;
            }

            public void Save(string data)
            {
                _database.SaveData(data);
            }
    }
}