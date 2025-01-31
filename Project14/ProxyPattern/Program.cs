using ProxyPattern.AccessControlProxy;
using ProxyPattern.LazyProxy;
using ProxyPattern.ProxyPattern01;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello");

        Client client = new Client();
        ISubject subject = new Proxy();
        client.Execute(subject);

        var lazyProxy = new LazyProxy();
        lazyProxy.Request();

        var adminProxy = new AccessControlProxy("Admin");
        adminProxy.Request();

        var userProxy = new AccessControlProxy("User");
        userProxy.Request();
    }
}