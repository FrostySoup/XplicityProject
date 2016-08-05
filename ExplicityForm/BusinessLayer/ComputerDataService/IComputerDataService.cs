using DataLayer.DatabaseData;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BusinessLayer.ComputerDataService
{
    public interface IComputerDataService
    {
        //Returns single computer details by predicate, async
        Task<ComputerDetail> GetComputerDetails(Expression<Func<ComputerDetail, bool>> predicate);

        //Returns all computers details that matches predicate
        List<ComputerDetail> GetAllComputerDetails(Expression<Func<ComputerDetail, bool>> predicate);

        //Add new computer if its name is not matching names in database
        bool AddComputer(ComputerDetail computerDetail);
    }
}
