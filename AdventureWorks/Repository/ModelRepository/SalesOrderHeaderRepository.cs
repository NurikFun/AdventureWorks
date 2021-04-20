using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.Repository.ModelRepository
{
    public class SalesOrderHeaderRepository : Repository<SalesOrderHeader>
    {
        public SalesOrderHeaderRepository(AdventureWorkContext context) : base(context)
        {

        }
    }

}
