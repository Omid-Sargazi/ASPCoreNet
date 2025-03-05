using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSupportTicketManagement.DocumentProcessingSystem
{
    public class WordDocument : IDocument
    {
        public int Id { get; private set; }

        public string Name { get; private set; }

        public string Content { get; private set; }

        public string Format => "DOCX";

        public WordDocument(int id, string name, string content)
        {
            Id = id;
            Name = name;
            Content = content;
        }
    }
}