using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DataLayer.DatabaseData;
using Microsoft.Data.Entity;

namespace Repository.Repository
{
    public class UsageDataRepository
    {
        public async Task<UsageData> GetItemAsync(Expression<Func<UsageData, bool>> predicate)
        {
            using (var context = new MetrixContext())
            {
                return await context.UsageDatas
                        .FirstOrDefaultAsync(predicate);
            }
        }

        public bool AddNewItem(UsageData usageData)
        {
            using (var context = new MetrixContext())
            {
                try
                {
                    context.UsageDatas.Add(usageData);
                    context.SaveChanges();
                }
                catch
                {
                    return false;
                }
                return true;
            }
        }

        public List<UsageData> GetAllItemsWhere(Expression<Func<UsageData, bool>> predicate)
        {
            using (var context = new MetrixContext())
            {
                return context.UsageDatas
                        .Where(predicate)
                        .ToList();
            }
        }
    }
}
