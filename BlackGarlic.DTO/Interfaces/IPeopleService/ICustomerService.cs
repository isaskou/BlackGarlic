using BlackGarlic.DTO.Interfaces.IServices;
using BlackGarlic.DTO.Models.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackGarlic.DTO.Interfaces.IPeopleService
{
    public interface ICustomerService : IService<Customer>
    {
        Customer GetCustomerByMail(string mail);
        IEnumerable<Customer> GetCustomersWithAdress(CustomerAdress customerAdress);
        IEnumerable<Customer> GetCustomersByPersonName(string name);
        Customer GetCustomerWithAllInformationById(int id);

    }
}
