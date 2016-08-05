using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Context
{
    public static class ContextEnsure
    {
        public static void EnsureDb()
        {
            using (var db = new MetrixContext())
            {
                db.Database.EnsureCreated();
            }
        }
    }
}
