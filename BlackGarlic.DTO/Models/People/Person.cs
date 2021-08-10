using System.Collections.Generic;

namespace BlackGarlic.DTO.Models.People
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public Role Role { get; set; }

        public Person()
        {
        }

        public Person(int id, string firstName, string lastName, string email, string password, string salt, Role role)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            Salt = salt;
            Role = role;
        }
    }
}