using HolyBook.DataAccess.Data;
using HolyBook.DataAccess.Repository.IRepository;
using HolyBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HolyBook.DataAccess.Repository
{
    public class ShoppingCartRepository : Repository<ShoppingCart>, IShoppingCartRepository
    {
        private readonly ApplicationDbContext _db;

        public ShoppingCartRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(ShoppingCart obj)
        {
            _db.Update(obj);
        }
    }
}


