using BlackGarlic.DAL.Models.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackGarlic.DAL.Interfaces.IPeopleRepos
{
    public interface IUserRepository
    {
        //Person GetPersonByMailAndPasswordMatch(string email, string password);

        //bool UpdatePersonWithoutPassword(Person person);

        bool FindEmail(string email, int id);
    }
}
