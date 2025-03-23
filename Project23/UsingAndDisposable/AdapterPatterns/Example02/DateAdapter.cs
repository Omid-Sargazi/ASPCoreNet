using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.AdapterPatterns.Example02
{
    public class DateAdapter : IDateProvider
    {
        private readonly ExternalDateService _externalDateService;

        public DateAdapter(ExternalDateService externalDateService)
        {
            _externalDateService = externalDateService;
        }
        public DateTime GetFormattedDate()
        {
           var dateStr =  _externalDateService.GetDate();
           return DateTime.ParseExact(dateStr,"MM/dd/yyyy",CultureInfo.InvariantCulture);
        }
    }
}