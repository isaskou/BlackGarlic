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

        public bool FindEmail(string email, int id)
        {
            Command cmd = new Command("SP_FindEmail", true);
            cmd.AddParameters("@Email", email);
            cmd.AddParameters("@UserId", id);
            int? exist = (int?)_connection.ExecuteScalar(cmd);
            if (exist > 0) return true;
            return false;
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

        public Customer GetCustomerByMailAndPasswordMatch(string email, string password)
        {
            Command cmd = new Command("SP_GetCustomerByMailAndPasswordMatch", true);
            cmd.AddParameters("@email", email);
            cmd.AddParameters("@password", password);

            return _connection.ExecuteReader(cmd, Converter.CustomerConvert).SingleOrDefault();
        }

        public IEnumerable<Customer> GetCustomersByLastName(string name)
        {
            Command cmd = new Command("SP_GetCustomerByLastName", true);
            cmd.AddParameters("@ln", name);
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
            Command cmd = new Command("SP_RegisterCustomer", true);
            cmd.AddParameters("Email", entity.Email);
            cmd.AddParameters("Password", entity.Password);
            return (int)_connection.ExecuteScalar(cmd);

        }

        public void Update(Customer entity)
        {
            Command cmd = new Command("SP_UpdateCustomer", true);
            cmd.AddParameters("customerId", entity.Id);
            cmd.AddParameters("@fn", entity.FirstName);
            cmd.AddParameters("@ln", entity.LastName);
            cmd.AddParameters("@company", entity.CompanyName);
            cmd.AddParameters("@Email", entity.Email);
            cmd.AddParameters("@Pw", entity.Password);
            cmd.AddParameters("@Phone", entity.Phone);

            _connection.ExecuteNonQuery(cmd);
        }

        public void UpdateCustomerWithoutPassword(Customer entity)
        {
            Command cmd = new Command("SP_UpdateCustomerWithoutPassord", true);
            cmd.AddParameters("customerId", entity.Id);
            cmd.AddParameters("@fn", entity.FirstName);
            cmd.AddParameters("@ln", entity.LastName);
            cmd.AddParameters("@company", entity.CompanyName);
            cmd.AddParameters("@Email", entity.Email);
            cmd.AddParameters("@Phone", entity.Phone);

            _connection.ExecuteNonQuery(cmd);

        }
    }
}
