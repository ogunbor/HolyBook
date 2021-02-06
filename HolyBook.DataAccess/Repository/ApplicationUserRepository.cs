using HolyBook.DataAccess.Data;
using HolyBook.DataAccess.Repository.IRepository;
using HolyBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HolyBook.DataAccess.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private readonly ApplicationDbContext _db;

        public ApplicationUserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


    }
}

