using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototypeExamples.API.Document
{
    public class ExcelDocument : Document
    {
        public ExcelDocument()
        {
            Title = "Excel Document";
            Content = "This is an Excel spreadsheet content.";   
        }
        public override Document Clone()
        {
            return (Document)this.MemberwiseClone();
        }
    }
}