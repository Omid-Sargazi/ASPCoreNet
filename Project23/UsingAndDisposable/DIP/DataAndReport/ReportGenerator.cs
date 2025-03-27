using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.DIP.DataAndReport
{
    public class ReportGenerator : IReportGenerator
    {
        public void GenerateReport(IEnumerable<object> data)
        {
            throw new NotImplementedException();
        }
    }
}