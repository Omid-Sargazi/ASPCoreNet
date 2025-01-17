using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrivenDesign.Events
{
    public static class DomainEvents
    {
        public static readonly List<Delegate> _handlers = new List<Delegate>();

        public static void Register<T>(Action<T> handler) where T:DomainEvent
        {
            _handlers.Add(handler);
        }

        public static void Raise<T>(T domainEvent) where T:DomainEvent
        {
            var relevantHandlers = _handlers.OfType<Action<T>>();
            foreach(var handler in relevantHandlers)
                handler(domainEvent);
        }

        public static async Task RaiseAsync<T>(T domainEvent) where T:DomainEvent
        {
            var relevantHandlers = _handlers.OfType<Func<T,Task>>();

            foreach(var handler in relevantHandlers)
                await handler(domainEvent);
        }
    }
}