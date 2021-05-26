using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PetCenter.Microservice.Models;

namespace PetCenter.Microservice.DBContexts
{
    public interface IPetCenterDbContext
    {
        DbSet<PetCenters> PetCenters { get; set; }
        Task<int> SaveChanges();
    }
}
