﻿using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.Repository.ModelRepository
{
    public class ProductRepository : Repository<Product>
    {
        public ProductRepository(AdventureWorkContext context) : base(context)
        {

        }
    }
}
