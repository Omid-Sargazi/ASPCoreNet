using DIPractice.DIFirstProject;

public class Program
{
    public static void Main(string[] args)
    {
        IMessageWriter writer = new ConsoleMessageWriter();
        var salutation = new Salutation(writer);
        salutation.Exclaim();
    }
}