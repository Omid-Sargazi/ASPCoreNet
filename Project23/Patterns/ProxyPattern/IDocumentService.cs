using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patterns.ProxyPattern
{
    public interface IDocumentService
    {
        string GetDocument(string documentId);
    }
}