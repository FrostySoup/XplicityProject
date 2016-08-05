using System;

namespace DataLayer.DatabaseData
{
    public class UsageData
    {
        public int CpuUsage { get; set; }
        public int RamUsage { get; set; }
        public int AvailableDiskSpaceGb { get; set; }
        public int AverageDiskQueueLength { get; set; }
        public DateTime? Time { get; set; }
        public int UsageDataId { get; set; }

        public UsageData(int cpuUsage, int ramUsage, int availableDiskSpaceGb, int averageDiskQueueLength)
        {
            CpuUsage = cpuUsage;
            RamUsage = ramUsage;
            AvailableDiskSpaceGb = availableDiskSpaceGb;
            AverageDiskQueueLength = averageDiskQueueLength;
            Time = DateTime.Now;
        }
    }
}
