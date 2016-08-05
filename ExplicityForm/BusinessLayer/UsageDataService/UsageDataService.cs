using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.DatabaseData;
using Repository.Repository;

namespace BusinessLayer.UsageDataService
{
    public class UsageDataService : IUsageDataService
    {
        private readonly UsageDataRepository _usageDataRepository = new UsageDataRepository();

        public bool AddUsageData(UsageData usageData)
        {
            return _usageDataRepository.AddNewItem(usageData);
        }
    }
}
