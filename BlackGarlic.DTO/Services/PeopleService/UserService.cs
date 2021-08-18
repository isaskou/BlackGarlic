using BlackGarlic.DAL.Interfaces.IPeopleRepos;
using BlackGarlic.DTO.Interfaces.IPeopleService;
using BlackGarlic.DTO.Models.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackGarlic.DTO.Services.PeopleService
{
    public class UserService :  IUserService
    {
        private IUserRepository _repo;

        public UserService(IUserRepository repo)
        {
            _repo = repo;
        }

        public bool FindEmail(string email, int idUser)
        {
            return _repo.FindEmail(email, idUser);
        }

        //public Person GetClientByMailAndPasswordMatch(string email, string password)
        //{
        //    throw new NotImplementedException();
        //}

        //public Person GetUserWithAllInformationById(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool UpdateClientWithoutPassword(Person person)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
