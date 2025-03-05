using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerSupportTicketManagement.Enums;
using CustomerSupportTicketManagement.Interfaces;

namespace CustomerSupportTicketManagement.Implements
{
    public class PriorityBasedRoutingStrategy : ITicketRoutingStrategy
    {
        private readonly Dictionary<TicketPriority, string> _priorityAgentMap;

        public PriorityBasedRoutingStrategy()
        {
            _priorityAgentMap = new Dictionary<TicketPriority, string>
            {
                {TicketPriority.Critical,"Senior Support Agent"},
                {TicketPriority.High,"Senior Support Agent"},
                {TicketPriority.Medium,"Mid-level, Support Agent"},
                {TicketPriority.Low, "Junior Support Agent"}
            };
        }
        public string RouteTicket(ITicket ticket)
        {
            return _priorityAgentMap[ticket.Priority];
        }
    }
}