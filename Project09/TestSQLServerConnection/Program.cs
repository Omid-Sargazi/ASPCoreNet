using System;
using Microsoft.Data.SqlClient;
class Program
{
     static void Main(string[] args)
    {
        string connectionString = "Server= localhost; Database=BookStore; User Id=sa; password=15935755Omid$@;Encrypt=False;";

        using(var connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                Console.WriteLine("Connection successful!");

                string query = "SELECT name FROM sys.databases;";
                using(var command = new SqlCommand(query,connection))
                    using(var reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            Console.WriteLine(reader.GetString(0));
                        }
                    }
            }
            catch (Exception ex)
            {
                 Console.WriteLine($"Connection failed: {ex.Message}");
            }
        }    
    }
}