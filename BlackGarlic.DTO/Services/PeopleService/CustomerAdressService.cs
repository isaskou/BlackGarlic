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
    public class CustomerAdressService : ICustomerAdressService
    {
        private ICustomerAdressRepository _customerAdressRepo;

        public CustomerAdressService(ICustomerAdressRepository customerAdressRepo)
        {
            _customerAdressRepo = customerAdressRepo;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CustomerAdress> GetAll()
        {
            throw new NotImplementedException();
        }

        public CustomerAdress GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(CustomerAdress entity)
        {
            return _customerAdressRepo.Insert(entity.toDTO());
        }

        public void Update(CustomerAdress entity)
        {
            _customerAdressRepo.Update(entity.toDTO());
        }
    }
}
