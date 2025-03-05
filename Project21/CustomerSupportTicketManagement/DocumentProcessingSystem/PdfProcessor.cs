using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSupportTicketManagement.DocumentProcessingSystem
{
    public class PdfProcessor : IDocumentProcessor
    {
        public void Process(IDocument document)
        {
            if(document.Format != "PDF")
                 throw new InvalidOperationException("This processor only handles PDF documents");
            
             Console.WriteLine($"Processing PDF document: {document.Name}");
            Console.WriteLine($"Extracting text from PDF, parsing structure, and indexing content");
        }
    }
}