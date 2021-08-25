using BlackGarlic.DAL.Interfaces.IPeopleRepos;
using BlackGarlic.DTO.Interfaces.IPeopleService;
using BlackGarlic.DTO.Models.People;
using BlackGarlic.DTO.Tools.PeopleMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackGarlic.DTO.Services.PeopleService
{
    public class AdressService : IAdressService
    {
        private IAdressRepository _adressRepository;

        public AdressService(IAdressRepository adressRepository)
        {
            _adressRepository = adressRepository;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Adress GetAdressByCustomerId(int id)
        {
            return _adressRepository.GetAdressByCustomerId(id).toDAL();
        }

        public IEnumerable<Adress> GetAll()
        {
            throw new NotImplementedException();
        }

        public Adress GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Adress entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Adress entity)
        {
            throw new NotImplementedException();
        }
    }
}
