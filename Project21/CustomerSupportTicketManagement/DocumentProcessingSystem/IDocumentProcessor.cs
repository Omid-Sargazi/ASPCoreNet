using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSupportTicketManagement.DocumentProcessingSystem
{
    public interface IDocumentProcessor
    {
        void Process(IDocument document);
    }
}