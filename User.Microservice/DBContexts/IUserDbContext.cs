using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using User.Microservice.Models;

namespace User.Microservice.DBContexts
{
    public interface IUserDbContext
    {
        DbSet<Users> Users { get; set; }
        Task<int> SaveChanges();
    }
}
