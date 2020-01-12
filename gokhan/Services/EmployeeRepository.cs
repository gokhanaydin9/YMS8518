﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Services
{
    public class EmployeeRepository : Repository<Models.Employee>, Interfaces.IEmployeeRepository
    {
        public EmployeeRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
