using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DataHelpers
{
    public class NewUsageData
    {
        public DateTime TimeStamp { get; set; }

        public double ProcessorUsage { get; set; }

        public double MemoryUsage { get; set; }
    }
}
