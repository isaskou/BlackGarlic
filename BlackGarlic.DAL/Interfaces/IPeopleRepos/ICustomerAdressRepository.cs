using BlackGarlic.DAL.Interfaces.IRepo;
using BlackGarlic.DAL.Models.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackGarlic.DAL.Interfaces.IPeopleRepos
{
    public interface ICustomerAdressRepository : IRepository<CustomerAdress, int>
    {
    }
}
