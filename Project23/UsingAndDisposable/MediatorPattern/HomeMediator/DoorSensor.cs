using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.MediatorPattern.HomeMediator
{
    public class DoorSensor
    {
        private IHomeMediator _mediator;
        public void SetMediator(IHomeMediator mediator) => _mediator = mediator;
        public void OpenDoor()
        {
            Console.WriteLine("DoorSensor: در باز شد.");
            _mediator.Notify("DoorSensor", "DoorOpened");
        }

        public void CloseDoor()
        {
            Console.WriteLine("DoorSensor: در بسته شد.");
            _mediator.Notify("DoorSensor", "DoorClosed");
        }
    }
}