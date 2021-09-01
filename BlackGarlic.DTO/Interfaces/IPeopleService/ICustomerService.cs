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
        Customer GetCustomerWithAllInformationById(int id);

        Customer GetCustomerByMail(string email);

        IEnumerable<Customer> GetCustomersByLastName(string name);

        Customer GetCustomerByMailAndPasswordMatch(string email, string password);

        void UpdateCustomerWithoutPassword(Customer customer);

        bool FindEmail(string email, int id);

    }
}
