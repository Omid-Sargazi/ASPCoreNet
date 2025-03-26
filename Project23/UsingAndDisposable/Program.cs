using Microsoft.VisualBasic;
using UsingAndDisposable;
using UsingAndDisposable.AdapterPatterns.Example04;
using UsingAndDisposable.BridgePattern02.OnAndOff;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello");

        // using(StreamWriter writer = new StreamWriter("example.txt"))
        // {
        //     writer.WriteLine("Hello World");
        // }
        // Console.WriteLine("The file has been written");

        // using(FileManager fm = new FileManager("temp.txt"))
        // {
        //     fm.Write("this is a test");
        // }
        // Console.WriteLine("کار تموم شد!");   

        // FahrenheitSensor fahrenheitSensor = new FahrenheitSensor();
        // ITemperature temperature = new TemperatureAdapter(fahrenheitSensor);
        //         Console.WriteLine($"Temperature in Celsius: {temperature.GetTemperatureInCelsius()}");

        // /////////////////////bridge pattern///////////////////////////////
        
        // IDevice tv = new TV();
        // IDevice fan = new Fan();

        // RemoteControl remoteControl = new BasicRemote(tv);
        // remoteControl.TurnOff();
        // remoteControl.TurnOn();
        // remoteControl = new BasicRemote(fan);
        // remoteControl.TurnOff();
        // remoteControl.TurnOn();


        string name = null;
        if(name !=null)
        {
            Console.WriteLine(name.Length);
        }


        string inputt = null;
        string result = inputt ?? "Default value";
        Console.WriteLine($"{result}");

        string text = null;
        text ??= "Asign value";
        Console.WriteLine(text);

        string[] names = null;
        int? count = names?.Length;
        Console.WriteLine(count.HasValue ? count.Value:-1);

        names = new[] {"Alice", "Omid"};
        count = names?.Length;
        Console.WriteLine(count);

        string[] items = null;
        int length = items?.Length ?? 0;
        Console.WriteLine(length);
        

    }

    public void ProcessData(string data)
    {
        if(data == null)
        {
            Console.WriteLine("Data is null, exiting.");
            return;
        }
        Console.WriteLine($"Processing: {data}");
    }

    

}