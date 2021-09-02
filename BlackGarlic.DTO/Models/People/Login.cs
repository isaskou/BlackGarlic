using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackGarlic.DTO.Models.People
{
    public class Login
    {
        public int? UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
