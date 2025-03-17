using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Patterns.ProxyPattern
{
    public class DocumentServiceProxy : IDocumentService
    {
        private  IDocumentService _realService;
         private Dictionary<string, string> _cache;
        private Dictionary<string, List<string>> _accessRights;
        private Dictionary<string, Stopwatch> _performanceMetrics;

        public DocumentServiceProxy()
        {
            _cache = new Dictionary<string, string>();
            _performanceMetrics = new Dictionary<string, Stopwatch>();

             _accessRights = new Dictionary<string, List<string>>
        {
            { "admin", new List<string> { "Financial_Report_2024", "HR_Employee_Data", "Strategic_Plan_2025", "Product_Roadmap" } },
            { "manager", new List<string> { "Financial_Report_2024", "Strategic_Plan_2025", "Product_Roadmap" } },
            { "developer", new List<string> { "Product_Roadmap" } },
            { "intern", new List<string> { } }
        };   
        }
        public string GetDocument(string documentId, string user)
        {
            if(string.IsNullOrEmpty(documentId))
                return "Error:Document ID cannot be empty";

            if (!_accessRights.ContainsKey(user) || !_accessRights[user].Contains(documentId))
        {
            LogAccess(user, documentId, false);
            return "Access denied: You do not have permission to access this document";
        }
        
        // Check cache first
        if (_cache.ContainsKey(documentId))
        {
            LogAccess(user, documentId, true, "from cache");
            return _cache[documentId];
        }

        if (_realService == null)
        {
            _realService = new DocumentService();
        }
        
        // Start performance measurement
        var stopwatch = new Stopwatch();
        stopwatch.Start();


        string result = _realService.GetDocument(documentId);
        
        // Stop performance measurement
        stopwatch.Stop();
        _performanceMetrics[documentId] = stopwatch;
        
        // Cache result for future requests
        if (result != "Document not found")
        {
            _cache[documentId] = result;
        }
        
        // Log access
        LogAccess(user, documentId, true, $"took {stopwatch.ElapsedMilliseconds}ms");
        
        return result;


        }


        private void LogAccess(string user, string documentId, bool success, string additionalInfo="")
        {
            Console.WriteLine($"{DateTime.Now} - User {user} {(success ? "accessed" : "attempted to access")} document {documentId}. {additionalInfo}");
        }
        public string GetDocument(string documentId)
    {
        // This method is needed to implement the interface, but we won't use it directly
        throw new InvalidOperationException("User information is required for document access");
    }
    }
}