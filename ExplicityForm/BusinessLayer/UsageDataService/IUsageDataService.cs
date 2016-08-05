using DataLayer.DatabaseData;

namespace BusinessLayer.UsageDataService
{
    public interface IUsageDataService
    {
        bool AddUsageData(UsageData usageData);
    }
}
