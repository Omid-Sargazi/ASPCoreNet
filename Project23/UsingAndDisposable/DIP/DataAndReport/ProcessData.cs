using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace UsingAndDisposable.DIP.DataAndReport
{
    public class ProcessData
    {
        private readonly IDataSource _dataSource;
        private readonly IReportGenerator _reportGenerator;

        public ProcessData(IDataSource dataSource, IReportGenerator reportGenerator)
        {
            _dataSource = dataSource;
            _reportGenerator = reportGenerator;
        }


        public void ProcessAndGenerateReport()
        {
            var data = _dataSource.GetData();
            _reportGenerator.GenerateReport(data);
        }


        
    }
}