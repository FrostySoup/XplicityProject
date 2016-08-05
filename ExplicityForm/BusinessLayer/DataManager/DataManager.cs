using System.Collections.Generic;
using System.Threading.Tasks;
using DataLayer.DataHelpers;

namespace BusinessLayer.DataManager
{
    public abstract class DataManager
    {
        public abstract ComputerSummary GetComputerSummary();
        public abstract Task<List<string>> GetApplicationList();
        public abstract List<string> GetHardwareList();
        public abstract int GetComputerCpuUsage();
        public abstract int GetComputerAverageLenght();
        public abstract int GetRam();
    }
}
