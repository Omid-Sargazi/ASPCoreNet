using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSupportTicketManagement.DocumentProcessingSystem
{
    public interface IDocument
    {
        int Id {get;}
        string Name {get;}
        string Content {get;}
        string Format {get;} 
    }
}