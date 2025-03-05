using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSupportTicketManagement.DocumentProcessingSystem
{
    public class WordProcessor : IDocumentProcessor
    {
        public void Process(IDocument document)
        {
            if (document.Format != "DOCX")
                throw new InvalidOperationException("This processor only handles Word documents");
                
            Console.WriteLine($"Processing Word document: {document.Name}");
            Console.WriteLine($"Parsing document structure, extracting metadata, and indexing content");
        }
    }
}