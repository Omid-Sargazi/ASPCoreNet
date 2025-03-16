using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patterns.ProxyPattern
{
    public class DocumentService : IDocumentService
    {
        private Dictionary<string, string> _documents;

        public DocumentService()
        {
            Console.WriteLine("DocumentService: Initializing and loading all documents...");
             _documents = new Dictionary<string, string>
        {
            { "Financial_Report_2024", "Our finances are looking strong this year..." },
            { "HR_Employee_Data", "Confidential employee information..." },
            { "Strategic_Plan_2025", "Our company plans to expand into new markets..." },
            { "Product_Roadmap", "Next year we will release the following products..." }
        };
        }
        public string GetDocument(string documentId)
        {
             if (_documents.ContainsKey(documentId))
        {
            return _documents[documentId];
        }
        
        return "Document not found";
        }
    }
}