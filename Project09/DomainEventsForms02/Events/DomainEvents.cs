using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DomainEventsForms02.Events
{
    public static class DomainEvents
    {
        private static readonly List<Delegate> Handlers = new List<Delegate>();
        
        public static void Register<T>(Action<T> handler) where T:class
        {
            Handlers.Add(handler);
        }

        public static void Raise<T>(T domainEvent) where T :class
        {
            foreach(var handler in Handlers.OfType<Action<T>>())
            {
                handler(domainEvent);
            }
        }

    }
}