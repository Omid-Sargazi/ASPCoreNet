using Microsoft.VisualBasic;
using UsingAndDisposable;
using UsingAndDisposable.AdapterPatterns.Example04;
using UsingAndDisposable.AdapterPatterns.Example05;
using UsingAndDisposable.BridgePattern;
using UsingAndDisposable.BridgePattern02.OnAndOff;
using UsingAndDisposable.CommandPattern;
using UsingAndDisposable.DIP;
using UsingAndDisposable.MediatorPattern;
using UsingAndDisposable.ProxyPattern.BankAccount;
using UsingAndDisposable.ProxyPattern.Printer;
namespace UsingAndDisposable.CommandPattern;


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


        IBankAccount account01 = new BankAccountProxy(10000,true);
        account01.ShowBalance();
        // account01 = new BankAccountProxy(10000,false);
        account01.ShowBalance();

        UsingAndDisposable.ProxyPattern.Printer.IPrinter printer01 = new PrinterProxy(true);
        printer01.Print("example.pdf");

        /// <summary>
        /// ////////////////////DIP//////////////////////
        /// </summary>
        /// <param name="data"></param>

        var emailNotifier = new Notification(new EmailSender());
        emailNotifier.Notify("Hello via Email");

        var smsNotifier  = new Notification(new SmsSender());
        smsNotifier.Notify("Helllo via SMS");

        Light light = new Light();
        ICommand turnon = new TurnOnLightCommand(light);
        ICommand turnoff = new TurnOffLightCommand(light);

        RemoteControl remoteControl = new RemoteControl();
        remoteControl.SetCommand(turnon);
        remoteControl.PressButton();
        remoteControl.PressUndo();

        IChatRoom chatRoom = new ChatRoom();
        User mikel = new User(chatRoom, "Mike");
        User sara = new User(chatRoom, "Sara");
        mikel.Send("message from mike");
        sara.Send("message from sara");

        
        

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