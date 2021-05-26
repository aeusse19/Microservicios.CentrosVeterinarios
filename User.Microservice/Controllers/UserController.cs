using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using User.Microservice.DBContexts;
using User.Microservice.Models;

namespace User.Microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserDbContext _context;
        public UserController(IUserDbContext context)
        {
            _context = context;
        }


        [HttpPost]
        public async Task<IActionResult> Create(Users user)
        {
            user.CreatedDate = DateTime.Now;
            _context.Users.Add(user);
            await _context.SaveChanges();
            return Ok(user.Id);
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var users = await _context.Users.ToListAsync();
            if (users == null) return NotFound();
            return Ok(users);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var user = await _context.Users.Where(a => a.Id == id).FirstOrDefaultAsync();
            if (user == null) return NotFound();
            return Ok(user);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var user = await _context.Users.Where(a => a.Id == id).FirstOrDefaultAsync();
            if (user == null) return NotFound();
            else
            {
                //_context.Users.Remove(user);
                user.DeletedDate = DateTime.Now;
            }           
            await _context.SaveChanges();
            return Ok(user.Id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Users userData)
        {
            var user = _context.Users.Where(a => a.Id == id).FirstOrDefault();
            if (user == null) return NotFound();
            else
            {
                user.Name = userData.Name;
                user.FirstName = userData.FirstName;
                user.LastName = userData.LastName;
                user.TypeDocumentID = userData.TypeDocumentID;
                user.DocumentNumber = userData.DocumentNumber;
                user.Email = userData.Email;
                user.CellPhone = userData.CellPhone;
                user.Address = userData.Address;
                user.UserName = userData.UserName;
                user.Password = userData.Password;
                user.UserProfileID = userData.UserProfileID;
                user.PetCenterID = userData.PetCenterID;
                user.Status = userData.Status;
                user.UpdatedDate = DateTime.Now;
                await _context.SaveChanges();
                return Ok(user.Id);
            }
        }
    }
}
