using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototypeExamples.API.Document
{
    public abstract class Document
    {
        public string Title {get;set;} = "Untitled";
        public string Content {get; set;}  ="Empty document...";


        public abstract Document Clone();   
    }
}