using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookstoreManagementSystem.Domain.Events
{
    public static class DomainEvents
    {
        private static readonly List<Delegate> _handlers = new List<Delegate>();

       public static void Register<T>(Action<T> handler) where T : DomainEvent
        {
            _handlers.Add(handler);
        }

        public static void Raise<T>(T domainEvent) where T:DomainEvent
        {
            foreach(var handler in _handlers.OfType<Action<T>>())
            {
                handler(domainEvent);
            }
        }

        public static async Task RaiseAsync<T>(T domainEvent) where T:DomainEvent
        {
            var relevantHandlers = _handlers.OfType<Func<T,Task>>();
            foreach(var handler in relevantHandlers)
            {
                await handler(domainEvent);
            }
        }
    }
}