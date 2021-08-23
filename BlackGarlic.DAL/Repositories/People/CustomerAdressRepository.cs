using BlackGarlic.DAL.Interfaces.IPeopleRepos;
using BlackGarlic.DAL.Models.People;
using BlackGarlic.DAL.Repositories.Base;
using ConnectionTool;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackGarlic.DAL.Repositories.People
{
    public class CustomerAdressRepository : BaseRepository, ICustomerAdressRepository
    {
        public CustomerAdressRepository(IConfiguration config) : base(config)
        {
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CustomerAdress> GetAll()
        {
            throw new NotImplementedException();
        }

        public CustomerAdress GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(CustomerAdress entity)
        {
            Command cmd = new Command("SP_AddCustomerAdress", true);
            cmd.AddParameters("CustomerId", entity.CustomerId);
            cmd.AddParameters("AdressId", entity.AdressId);

            return (int)_connection.ExecuteScalar(cmd);
        }

        public void Update(CustomerAdress entity)
        {
            Command cmd = new Command("SP_UpdateCustomerAdress", true);
            cmd.AddParameters("CustomerId", entity.CustomerId);
            cmd.AddParameters("AdressId", entity.AdressId);

            _connection.ExecuteNonQuery(cmd);
        }
    }
}
