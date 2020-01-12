using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Services
{
    public class CustomerRepository : Repository<Models.Customer>, Interfaces.ICustomerRepository
    {
        public CustomerRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
