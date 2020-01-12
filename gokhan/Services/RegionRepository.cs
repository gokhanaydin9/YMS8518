﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Services
{
    public class RegionRepository : Repository<Models.Region>, Interfaces.IRegionRepository
    {
        public RegionRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
