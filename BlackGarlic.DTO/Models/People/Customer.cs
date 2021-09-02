using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackGarlic.DTO.Models.People
{
    public class Customer
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }

        public List<Adress> Adresses { get; set; }

        public Customer()
        {
        }

        public Customer(int id, string companyName, string firstName, string lastName, string phone, string email, string password, int roleId, Role role, List<Adress> adresses)
        {
            Id = id;
            CompanyName = companyName;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Email = email;
            Password = password;
            RoleId = roleId;
            Role = role;
            Adresses = adresses;
        }
    }
}
