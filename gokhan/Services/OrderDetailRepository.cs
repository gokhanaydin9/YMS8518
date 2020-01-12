using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Services
{
    public class OrderDetailRepository : Repository<Models.OrderDetail>, Interfaces.IOrderDetailRepository
    {
        public OrderDetailRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
