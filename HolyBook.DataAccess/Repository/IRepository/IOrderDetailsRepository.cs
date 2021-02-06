using HolyBook.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HolyBook.DataAccess.Repository.IRepository
{
    public interface IOrderDetailsRepository : IRepository<OrderDetails>
    {
        void Update(OrderDetails obj);
    }
}
