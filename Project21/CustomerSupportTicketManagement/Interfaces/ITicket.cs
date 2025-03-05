using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerSupportTicketManagement.Enums;

namespace CustomerSupportTicketManagement.Interfaces
{
    public interface ITicket
    {
        string TicketId {get;}
        string CustomerName {get;}
        string Description {get;}
        TicketPriority Priority {get;}
        TicketCategory Category {get;}
        TicketStatus Status {get;}
        string AssignedTo {get;}
        DateTime CreatedAt {get;}
        void UpdateStatus(TicketStatus newStatus);
        void AssignToAgent(string agentName);
    }
}