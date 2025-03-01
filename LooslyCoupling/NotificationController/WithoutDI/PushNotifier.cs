using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LooslyCoupling.NotificationController.WithoutDI
{
    public class PushNotifier
    {
        private readonly string _apiKey;
        public PushNotifier(string apiKey)
        {
            _apiKey = apiKey;
        }   

        public void Notify(string message)
        {
            Console.WriteLine($"Push notification sent with API key {_apiKey}: {message}");
        }
    }
}