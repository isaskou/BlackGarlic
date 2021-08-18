using BlackGarlic.DTO.Models.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackGarlic.DTO.Interfaces.IPeopleService
{
    public interface IUserService
    {
        //Person GetUserWithAllInformationById(int id);

        //Person GetClientByMailAndPasswordMatch(string email, string password);

        //bool UpdateClientWithoutPassword(Person person);

        bool FindEmail(string email, int idUser);
    }
}
