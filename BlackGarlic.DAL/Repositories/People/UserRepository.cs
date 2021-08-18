using BlackGarlic.DAL.Interfaces.IPeopleRepos;
using BlackGarlic.DAL.Models.People;
using BlackGarlic.DAL.Repositories.Base;
using ConnectionTool;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackGarlic.DAL.Repositories.People
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(IConfiguration config) : base(config)
        {
        }

        public bool FindEmail(string email, int id)
        {
            Command cmd = new Command("SP_FindEmail", true);
            cmd.AddParameters("@Email", email);
            cmd.AddParameters("@UserId", id);
            int? exist = (int?)_connection.ExecuteScalar(cmd);
            if (exist > 0) return true;
            return false;
        }

        //public Person GetPersonByMailAndPasswordMatch(string email, string password)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool UpdatePersonWithoutPassword(Person person)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
