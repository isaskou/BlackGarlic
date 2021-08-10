using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackGarlic.DAL.Models.People
{
    public class Person
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public int AdressId { get; set; }
        public int RoleId { get; set; }

        public Adress Adress { get; set; }
        public Role Role { get; set; }
    }
}
