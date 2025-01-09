using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewareExamples03.DTOs
{
    public class PagedResult<T>
    {
        public List<T> Items {get;set;}
        public int TotalCount {get; set;}
    }
}