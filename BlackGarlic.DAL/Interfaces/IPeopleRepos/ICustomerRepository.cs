using BlackGarlic.DAL.Interfaces.IRepo;
using BlackGarlic.DAL.Models.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackGarlic.DAL.Interfaces.IPeopleRepos
{
    public interface ICustomerRepository : IRepository<Customer, int>
    {

        Customer GetCustomerByMail(string email);
        Customer GetCustomerByMailAndPasswordMatch(string email, string password);

        IEnumerable<Customer> GetCustomersByLastName(string name);

        void UpdateCustomerWithoutPassword(Customer entity);

        bool FindEmail(string email, int id);



    }
}
