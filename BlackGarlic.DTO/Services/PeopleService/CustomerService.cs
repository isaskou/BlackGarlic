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
        private IAdressRepository _adressRepository;
        private ICustomerAdressRepository _customerAdressRepository;
        private IRoleRepository _roleRepo;

        public CustomerService(ICustomerRepository customerRepo, IAdressRepository adressRepository, ICustomerAdressRepository customerAdressRepository, IRoleRepository roleRepository)
        {
            _customerRepo = customerRepo;
            _adressRepository = adressRepository;
            _customerAdressRepository = customerAdressRepository;
            _roleRepo = roleRepository;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool FindEmail(string email, int id)
        {
            return _customerRepo.FindEmail(email, id);
        }

        public IEnumerable<Customer> GetAll()
        {
            return _customerRepo.GetAll().Select(x => x.toDAL());
        }

        public Customer GetById(int id)
        {
            return _customerRepo.GetOne(id).toDAL();
        }


        public Customer GetCustomerByMail(string mail)
        {
            return _customerRepo.GetCustomerByMail(mail).toDAL();
        }

        public Customer GetCustomerByMailAndPasswordMatch(string email, string password)
        {
            Customer c = _customerRepo.GetCustomerByMailAndPasswordMatch(email, password).toDAL();

            if(c != null)
            {
                c.Role = new Role();
                c.Role = _roleRepo.GetOne(c.Id).toDAL();
            }
            return c;
        }

        public IEnumerable<Customer> GetCustomersByLastName(string name)
        {
            return _customerRepo.GetCustomersByLastName(name).Select(x => x.toDAL());

        }

        public IEnumerable<Customer> GetCustomersWithAdress(CustomerAdress customerAdress)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomerWithAllInformationById(int id)
        {
            Customer customer = _customerRepo.GetOne(id).toDAL();
            customer.Role = new Role();
            customer.Adresses = new List<Adress>();

            foreach (Adress a in _adressRepository.GetAllAdressesByCustomerId(id).Select(x=>x.toDAL()))
            {
                customer.Adresses.Add(a);
            }
            customer.Role=_roleRepo.GetOne(customer.RoleId).toDAL();
            return customer;
        }

        public int Insert(Customer entity)
        {
            return _customerRepo.Insert(entity.toDTO());
        }

        public void Update(Customer entity)
        {
            _customerRepo.Update(entity.toDTO());
        }

        public void UpdateCustomerWithoutPassword(Customer customer)
        {
            _customerRepo.UpdateCustomerWithoutPassword(customer.toDTO());
        }
    }
}
