using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using User.Microservice.Models;

namespace User.Microservice.DBContexts
{
    public class UserDbContext : DbContext, IUserDbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
        }
        public DbSet<Users> Users { get; set; }
        public DbSet<TypeDocument> TypeDocuments { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<PetCenter> PetCenters { get; set; }
        public async Task<int> SaveChanges()
        {
            return await base.SaveChangesAsync();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TypeDocument>().HasData(
                new TypeDocument
                {
                    Id = 1,
                    Name = "Cédula de ciudadania",
                    Description = "CC",
                    Status = "Activo",
                    CreatedDate = DateTime.Now
                },
                new TypeDocument
                {
                    Id = 2,
                    Name = "Cédula de extranjeria",
                    Description = "CE",
                    Status = "Activo",
                    CreatedDate = DateTime.Now
                },
                new TypeDocument
                {
                    Id = 3,
                    Name = "Tarjeta de identidad",
                    Description = "TI",
                    Status = "Activo",
                    CreatedDate = DateTime.Now
                },
                new TypeDocument
                {
                    Id = 4,
                    Name = "Registro civil",
                    Description = "RC",
                    Status = "Activo",
                    CreatedDate = DateTime.Now
                }
            );
            modelBuilder.Entity<UserProfile>().HasData(
                new UserProfile
                {
                    Id = 1,
                    Name = "Administrador",
                    Description = "Admin",
                    Status = "Activo",
                    CreatedDate = DateTime.Now
                },
                new UserProfile
                {
                    Id = 2,
                    Name = "Cliente",
                    Description = "Cliente",
                    Status = "Activo",
                    CreatedDate = DateTime.Now
                },
                new UserProfile
                {
                    Id = 3,
                    Name = "Médico veterinario",
                    Description = "Médico veterinario",
                    Status = "Activo",
                    CreatedDate = DateTime.Now
                }               
            );
            modelBuilder.Entity<PetCenter>().HasData(
               new PetCenter
               {
                   Id = 1,
                   Name = "Los Galgos",
                   Description = "Hospital veterinario, peluqueria y accesorios",
                   Status = "Activo",
                   City = "Manizales",
                   Address = "Av Del centro # 18 - 22",
                   Latitude = "5.069677694253585",
                   Longitude = "-75.51960687804086",
                   CreatedDate = DateTime.Now
               },
               new PetCenter
               {
                   Id = 2,
                   Name = "Maranata Mundo Animal",
                   Description = "Cnetro veterinario, peluqueria y accesorios",
                   Status = "Activo",
                   City = "Manizales",
                   Address = "Cra 23 # 15 05",
                   Latitude = "5.0707867012057015",
                   Longitude = "-75.51997221219987",
                   CreatedDate = DateTime.Now
               },
               new PetCenter
               {
                   Id = 3,
                   Name = "Huella Amiga",
                   Description = "Hospital veterinario, peluqueria y accesorios",
                   Status = "Activo",
                   City = "Manizales",
                   Address = "Alcazares Calle 5 # 20-04",
                   Latitude = "5.070783128280658",
                   Longitude = "-75.52664335097862",
                   CreatedDate = DateTime.Now
               }
           );
        }
    }
}
