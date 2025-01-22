using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Common;

namespace Infrastructure.Dispatcher
{
    public class EventDispatcher
    {
        private readonly Dictionary<Type, List<Action<IDomainEvent>>> _handlers = new();

        public void Register<TEvent>(Action<TEvent> handler) where TEvent: IDomainEvent
        {
            var eventType = typeof(TEvent);
            if(!_handlers.ContainsKey(eventType))
                _handlers[eventType] = new List<Action<IDomainEvent>>();
            
            _handlers[eventType].Add(e => handler((TEvent)e));
        }

        public void Dispatch(IDomainEvent domainEvent)
        {
            var eventType = domainEvent.GetType();

            if (_handlers.ContainsKey(eventType))
            {
                foreach (var handler in _handlers[eventType])
                {
                    handler(domainEvent);
                }
            }

    }
}