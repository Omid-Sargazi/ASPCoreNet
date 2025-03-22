using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdapterPattern.WeightProblem
{
    public class WeightAdapter : PoundScale, IWeight
    {
        public double GetWeightInKg()
        {
            double pounds = GetWeightInPounds();
            return pounds * 0.453592;
        }
    }
}