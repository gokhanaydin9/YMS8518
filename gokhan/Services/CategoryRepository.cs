﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Services
{
    public class CategoryRepository : Repository<Models.Category>,Interfaces.ICategoryRepository
    {
        public CategoryRepository(DataContext dataContext) : base(dataContext)
        {
           
        }
    }
}
