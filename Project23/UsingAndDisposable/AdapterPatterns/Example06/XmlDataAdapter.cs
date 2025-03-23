using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.AdapterPatterns.Example06
{
    public class XmlDataAdapter : IXmlDataProvider
    {
        private readonly JsonDataService _jsonDataService;
        public XmlDataAdapter(JsonDataService jsonDataService)
        {
            _jsonDataService = jsonDataService;
        }
        public string GetXmlData()
        {
           var json =  _jsonDataService.GetJsonData();
           return "<user><name>Ali</name></user>";
        }
    }
}