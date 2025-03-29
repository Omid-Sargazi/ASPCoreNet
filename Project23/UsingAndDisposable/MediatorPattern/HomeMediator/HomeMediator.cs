using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.MediatorPattern.HomeMediator
{
    public class HomeMediator : IHomeMediator
    {
        private DoorSensor _doorSensor;
        private Light _light;
        private Fan _fan;
        public HomeMediator(DoorSensor doorSensor, Light light, Fan fan)
        {
            _doorSensor = doorSensor;
            _light = light;
            _fan = fan;
            _doorSensor.SetMediator(this);
            _light.SetMediator(this);
            _fan.SetMediator(this);
        }
        
        public void Notify(string sender, string eventName)
        {
            if (sender == "DoorSensor" && eventName == "DoorOpened")
        {
            _light.TurnOn(); // لامپ رو روشن کن
            _fan.TurnOn();   // فن رو روشن کن
        }
        else if (sender == "DoorSensor" && eventName == "DoorClosed")
        {
            _light.TurnOff(); // لامپ رو خاموش کن
            _fan.TurnOff();   // فن رو خاموش کن
        }
        }
    }
}