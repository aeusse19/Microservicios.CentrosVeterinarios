using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetCenter.Microservice.DBContexts;
using PetCenter.Microservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetCenter.Microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetCenterController : ControllerBase
    {
        private IPetCenterDbContext _context;
        public PetCenterController(IPetCenterDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Create(PetCenters petCenter)
        {
            petCenter.CreatedDate = DateTime.Now;
            _context.PetCenters.Add(petCenter);
            await _context.SaveChanges();
            return Ok(petCenter.Id);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var petCenter = await _context.PetCenters.ToListAsync();
            if (petCenter == null) return NotFound();
            return Ok(petCenter);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var petCenter = await _context.PetCenters.Where(a => a.Id == id).FirstOrDefaultAsync();
            if (petCenter == null) return NotFound();
            return Ok(petCenter);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var petCenter = await _context.PetCenters.Where(a => a.Id == id).FirstOrDefaultAsync();
            if (petCenter == null) return NotFound();
            _context.PetCenters.Remove(petCenter);
            await _context.SaveChanges();
            return Ok(petCenter.Id);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, PetCenters petCenterData)
        {
            var petCenter = _context.PetCenters.Where(a => a.Id == id).FirstOrDefault();
            if (petCenter == null) return NotFound();
            else
            {
                petCenter.Name = petCenterData.Name;
                petCenter.Description = petCenterData.Description;
                petCenter.Status = petCenterData.Status;
                petCenter.City = petCenterData.City;
                petCenter.Address = petCenterData.Address;
                petCenter.Latitude = petCenterData.Latitude;
                petCenter.Longitude = petCenterData.Longitude;
                petCenter.Address = petCenterData.Address;
                petCenter.UpdatedDate = DateTime.Now;
                await _context.SaveChanges();
                return Ok(petCenter.Id);
            }
        }
    }
}
