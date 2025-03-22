using AdapterPattern.ImageViewer;
using AdapterPattern.MusicPlayer;
using AdapterPattern.Printer;
using AdapterPattern.Temperature;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello");
        ITemperature sensore = new TemperatureAdapter();
        Console.WriteLine($"Temperature in Celsius: {sensore.GetTemperatureInCelsius()}");

        /////////////////////////Printer Example/////////////////////////
        OldPrinter oldPrinter = new OldPrinter();
        IPrinter printer = new PrinterAdapter(oldPrinter);
        printer.Print("Sample.pdf");

        ///////////////////////////////IMusicPlayer///////////////////////
        IMusicPlayer player = new MusicAdapter();
        player.PlayMp3();

        /////////////////////////Image convertor by Adapter/////////////////////////
        BmpViewer bmpViewer = new BmpViewer();
        IImageViewer imageViewer = new ImageAdapter(bmpViewer);
        imageViewer.DisplayImage("Sample.png");
    }
}