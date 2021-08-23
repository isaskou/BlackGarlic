using BlackGarlic.DAL.Interfaces.IPeopleRepos;
using BlackGarlic.DAL.Models.People;
using BlackGarlic.DAL.Repositories.Base;
using BlackGarlic.DAL.Tools;
using ConnectionTool;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackGarlic.DAL.Repositories.People
{
    public class CustomerRepository : BaseRepository, ICustomerRepository
    {
        public CustomerRepository(IConfiguration config) : base(config)
        {
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAll()
        {
            Command cmd = new Command("SP_GetAllCustomers", true);
            return _connection.ExecuteReader(cmd, Converter.CustomerConvert);
        }


        public Customer GetCustomerByMail(string email)
        {
            Command cmd = new Command("SP_GetCustomerByMail", true);
            cmd.AddParameters("Email", email);
            return _connection.ExecuteReader(cmd, Converter.CustomerConvert).FirstOrDefault();
        }

        public IEnumerable<Customer> GetCustomersByName(string name)
        {
            Command cmd = new Command("SP_GetCustomerByPersonName", true);
            cmd.AddParameters("PersonLastName", name);
            return _connection.ExecuteReader(cmd, Converter.CustomerConvert);
        }

        public Customer GetOne(int id)
        {
            Command cmd = new Command("SP_GetCustomerById", true);
            cmd.AddParameters("CustomerId", id);
            return _connection.ExecuteReader(cmd, Converter.CustomerConvert).FirstOrDefault();
        }

        public int Insert(Customer entity)
        {
            Command cmd = new Command("SP_AddCustomer", true);
            cmd.AddParameters("CompanyName", entity.CompanyName);
            cmd.AddParameters("PersonId", entity.PersonId);
            cmd.AddParameters("Phone", entity.Phone);
            return (int)_connection.ExecuteScalar(cmd);

        }

        public void Update(Customer entity)
        {
            Command cmd = new Command("SP_UpdateCustomer", true);
            cmd.AddParameters("CompanyName", entity.CompanyName);
            cmd.AddParameters("CustomerId", entity.Id);
            cmd.AddParameters("Phone", entity.Phone);

            _connection.ExecuteNonQuery(cmd);
        }
    }
}
