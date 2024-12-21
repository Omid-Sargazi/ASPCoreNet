using System;

namespace DILibrary
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        //  ILibraryLogger libraryLogger = new FileLogger();
        //    libraryLogger.LogOperations("Loaned book: The Great Gatsby");

        //    libraryLogger = new DatabaseLogger();
        //    libraryLogger.LogOperations("Returned book: 1984");

        ILibraryLogger fileLogger = new FileLogger();
        LibraryManager libraryWithFileLogger = new LibraryManager(fileLogger);
        libraryWithFileLogger.LogMessage("Loaned book: The Great Gatsby");

        ILibraryLogger databaseLogger = new DatabaseLogger();
        LibraryManager libraryWithDatabaseLogger = new LibraryManager(databaseLogger);


        }
    }


    public interface ILibraryLogger
    {
        public void LogOperations(string message);
    }

    public class FileLogger : ILibraryLogger
    {
        public void LogOperations(string message)
        {
            Console.WriteLine($"[FileLogger] Logged to file: {message}");
        }
    }

    public class DatabaseLogger:ILibraryLogger
    {
        public void LogOperations(string message)
        {
            Console.WriteLine($"[DatabaseLogger] Logged to database: {message}");
        }
    }

    public class LibraryManager
    {
        private readonly ILibraryLogger _libraryLogger;

        public LibraryManager(ILibraryLogger libraryLogger)
        {
            _libraryLogger = libraryLogger;
        }

        public void LogMessage(string message)
        {
            _libraryLogger.LogOperations(message);
        }
    }
}