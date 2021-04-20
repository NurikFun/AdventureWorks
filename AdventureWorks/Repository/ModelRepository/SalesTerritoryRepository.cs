using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.Repository.ModelRepository
{
    public class SalesTerritoryRepository : Repository<SalesTerritory>
    {
        public SalesTerritoryRepository(AdventureWorkContext context) : base(context)
        {

        }

    }
}
