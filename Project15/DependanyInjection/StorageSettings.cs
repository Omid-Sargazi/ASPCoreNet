using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependanyInjection
{
    public class StorageSettings
    {
        public string StorageType {get; set;}
        public string LocalStoragePath {get; set;}
        public string CloudConnectionString {get;set;}
    }
}