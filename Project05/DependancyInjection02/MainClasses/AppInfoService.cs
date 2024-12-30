using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace DependancyInjection02.MainClasses
{
    public class AppInfoService
    {
        private readonly AppSettings _settings;
        public AppInfoService(IOptions<AppSettings> options)
        {   
            _settings = options.Value;
        }
        public void DisplayAppInfo()
        {
            Console.WriteLine($"App Name: {_settings.AppName}");
            Console.WriteLine($"Version: {_settings.Version}");
        }
    }
}