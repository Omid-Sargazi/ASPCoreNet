using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.AdapterPatterns.Example02
{
    public interface IDateProvider
    {
        public DateTime GetFormattedDate();
    }
}