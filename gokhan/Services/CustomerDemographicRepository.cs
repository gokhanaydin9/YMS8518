﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Services
{
    public class CustomerDemographicRepository : Repository<Models.CustomerDemographic>, Interfaces.ICustomerDemographicRepository
    {
        public CustomerDemographicRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
