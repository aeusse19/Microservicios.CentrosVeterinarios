using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace User.Microservice.Models
{
    public class Users : BaseEntity
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TypeDocumentID { get; set; }
        public string DocumentNumber { get; set; }
        public string Email { get; set; }
        public string CellPhone { get; set; }
        public string Address { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int UserProfileID { get; set; }
        public int PetCenterID { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public TypeDocument TypeDocument { get; set; }
        public UserProfile UserProfile { get; set; }
        public PetCenter PetCenter { get; set; }
    }
}
