using HolyBook.DataAccess.Data;
using HolyBook.DataAccess.Repository.IRepository;
using HolyBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HolyBook.DataAccess.Repository
{
    public class OrderHeaderRepository : Repository<OrderHeader>, IOrderHeaderRepository
    {
        private readonly ApplicationDbContext _db;

        public OrderHeaderRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(OrderHeader obj)
        {
            _db.Update(obj);
        }
    }
}


