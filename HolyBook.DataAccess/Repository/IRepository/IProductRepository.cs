using HolyBook.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HolyBook.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product product);
    }
}
