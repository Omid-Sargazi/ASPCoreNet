using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototypeExamples.API.Document
{
    public class WordDocument:Document
    {
        public WordDocument()
        {
            Title = "Word Document";
            Content = "This is a Microsoft Word document content.";
        }

        public override Document Clone()
        {
            return (Document)this.MemberwiseClone();
        }
    }
}