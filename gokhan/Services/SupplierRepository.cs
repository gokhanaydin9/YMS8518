using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Services
{
    public class SupplierRepository : Repository<Models.Supplier>, Interfaces.ISupplierRepository
    {
        public SupplierRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
