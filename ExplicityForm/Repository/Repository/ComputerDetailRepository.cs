using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataLayer.DatabaseData;
using Microsoft.Data.Entity;

namespace Repository.Repository
{
    public class ComputerDeatailRepository
    {
        public async Task<ComputerDetail> GetItemAsync(Expression<Func<ComputerDetail, bool>> predicate)
        {
            using (var context = new MetrixContext())
            {
                return await context.ComputerDetails
                        .FirstOrDefaultAsync(predicate);
            }
        }

        public bool AddNewItem(ComputerDetail computerDetail)
        {
            using (var context = new MetrixContext())
            {
                //Null exception when trying to retrieve data
                /*var value = context.ComputerDetails.FirstOrDefault(x => x.Name.Equals(computerDetail.Name));
                if (value != null)
                     return false;*/  
                context.ComputerDetails.Add(computerDetail);
                context.SaveChanges();
                return true;
            }
        }

        public List<ComputerDetail> GetAllItemsWhere(Expression<Func<ComputerDetail, bool>> predicate)
        {
            using (var context = new MetrixContext())
            {
                return context.ComputerDetails
                        .Where(predicate)
                        .ToList();
            }
        }

    }
}
