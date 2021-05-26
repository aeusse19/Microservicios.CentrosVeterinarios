using Microsoft.EntityFrameworkCore;
using PetCenter.Microservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetCenter.Microservice.DBContexts
{
    public class PetCenterDbContext : DbContext, IPetCenterDbContext
    {
        public PetCenterDbContext(DbContextOptions<PetCenterDbContext> options) : base(options)
        {
        }
        public DbSet<PetCenters> PetCenters { get; set; }
        public async Task<int> SaveChanges()
        {
            return await base.SaveChangesAsync();
        }
    }
}
