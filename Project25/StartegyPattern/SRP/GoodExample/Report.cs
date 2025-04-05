namespace  StartegyPattern.SRP.GoodExample
{
  public class Report
  {
      public string ReportText { get; set; }
    
    public void Generate()
    {
        Console.WriteLine("Report generated.");
    }
  }
}