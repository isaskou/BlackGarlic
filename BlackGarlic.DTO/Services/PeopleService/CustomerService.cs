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
    public class CustomerService : ICustomerService
    {
        private ICustomerRepository _customerRepo;
        private IPersonRepository _personRepository;

        public CustomerService(ICustomerRepository customerRepo, IPersonRepository personRepository)
        {
            _customerRepo = customerRepo;
            _personRepository = personRepository;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAll()
        {
            return _customerRepo.GetAll().Select(x => x.toDAL());
        }


        public Customer GetById(int id)
        {
            Customer c = _customerRepo.GetOne(id).toDAL();
            c.Person = _personRepository.GetOne(c.PersonId).toDTO();
            return c;
        }

        public Customer GetCustomerByMail(string mail)
        {
            return _customerRepo.GetCustomerByMail(mail).toDAL();
        }

        public IEnumerable<Customer> GetCustomersByPersonName(string name)
        {
            return _customerRepo.GetCustomersByName(name).Select(x => x.toDAL());
        }

        public IEnumerable<Customer> GetCustomersWithAdress(CustomerAdress customerAdress)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomerWithAllInformationById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Customer entity)
        {
            return _customerRepo.Insert(entity.toDTO());
        }

        public void Update(Customer entity)
        {
            _customerRepo.Update(entity.toDTO());
        }
    }
}
