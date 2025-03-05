using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerSupportTicketManagement.Enums;
using CustomerSupportTicketManagement.Interfaces;

namespace CustomerSupportTicketManagement.Implements
{
    public class SupportTicket : ITicket
    {
        public string TicketId {get; private set;}

        public string CustomerName {get; private set;}

        public string Description {get; private set;}

        public TicketPriority Priority {get; private set;}


        public TicketCategory Category {get; private set;}


        public TicketStatus Status {get; private set;}


        public string AssignedTo {get; private set;}


        public DateTime CreatedAt {get; private set;}


        public void AssignToAgent(string agentName)
        {
            AssignedTo = agentName;
            Status = TicketStatus.Assigned;
        }

        public void UpdateStatus(TicketStatus newStatus)
        {
            Status = newStatus;
        }
    }
}