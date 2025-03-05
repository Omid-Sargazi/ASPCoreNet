using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSupportTicketManagement.DocumentProcessingSystem
{
    public class DocumentManager
    {
        private readonly Dictionary<string, IDocumentProcessor> _proccessor;
        public DocumentManager(Dictionary<string,IDocumentProcessor> processor)
        {
            _proccessor = processor;            
        }

        public void ProcessDocument(IDocument document)
        {
            if(_proccessor.TryGetValue(document.Format, out var process))
                process.Process(document);
            else
                throw new InvalidOperationException($"No processor available for format: {document.Format}");
        }
    }
}