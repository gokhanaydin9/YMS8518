﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Services
{
    public class ProductRepository : Repository<Models.Product>, Interfaces.IProductRepository
    {
        public ProductRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
