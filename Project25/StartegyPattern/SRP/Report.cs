namespace  StartegyPattern.SRP
{
    public class Report
    {
        public string ReportText {get; set;}
        public void GenerateReport()
    {
        Console.WriteLine("Report generated.");
    }

    public void SaveToFile()
    {
        Console.WriteLine("Saving to file...");
    }

    public void SendByEmail()
    {
        Console.WriteLine("Sending email...");
    }
    }
}