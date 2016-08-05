using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DataLayer.DatabaseData;
using Repository.Repository;

namespace BusinessLayer.ComputerDataService
{
    public class ComputerDataService : IComputerDataService
    {
        private readonly ComputerDeatailRepository _computerDetailRep = new ComputerDeatailRepository();

        //Can't return data from database, please check it

        public async Task<ComputerDetail> GetComputerDetails(Expression<Func<ComputerDetail, bool>> predicate)
        {
            return await _computerDetailRep.GetItemAsync(predicate);
        }

        public List<ComputerDetail> GetAllComputerDetails(Expression<Func<ComputerDetail, bool>> predicate)
        {
            return _computerDetailRep.GetAllItemsWhere(predicate);
        }

        public bool AddComputer(ComputerDetail computerDetail)
        {
            return _computerDetailRep.AddNewItem(computerDetail);
        }
    }
}
