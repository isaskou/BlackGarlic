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
    public class PersonRepository : BaseRepository, IPersonRepository
    {
        public PersonRepository(IConfiguration config) : base(config)
        {
        }

        public bool Delete(int id)
        {
            Command cmd = new Command("DELETE FROM Person WHERE Id=@Id", false);
            cmd.AddParameters("Id", id);
            return _connection.ExecuteNonQuery(cmd) == 1;

        }

        public IEnumerable<Person> GetAll()
        {

            Command cmd = new Command("SP_GetAllPerson", true);
            return _connection.ExecuteReader(cmd, Converter.PersonConvert);
        }

        public Person GetOne(int id)
        {
            Command cmd = new Command("SP_GetPersonById", true);
            cmd.AddParameters("PersonId", id);
            return _connection.ExecuteReader(cmd, Converter.PersonConvert).SingleOrDefault();
        }

        public Person GetPersonByMail(string mail)
        {
            Command cmd = new Command("SP_GetPersonByMail", true);
            cmd.AddParameters("Email", mail);
            return _connection.ExecuteReader(cmd, Converter.PersonConvert).SingleOrDefault();
        }

        public IEnumerable<Person> GetPersonByName(string name)
        {
            Command cmd = new Command("SP_GetPersonByName", true);
            cmd.AddParameters("LastName", name);
            return _connection.ExecuteReader(cmd, Converter.PersonConvert);
        }

        public int Insert(Person entity)
        {
            Command cmd = new Command("SP_InsertPerson", true);
            cmd.AddParameters("FirstName", entity.FirstName);
            cmd.AddParameters("LastName", entity.LastName);
            cmd.AddParameters("Email", entity.Email);
            cmd.AddParameters("Password", entity.Password);
            cmd.AddParameters("RoleId", entity.RoleId);
            return (int)_connection.ExecuteScalar(cmd);
        }

        public void Update(Person entity)
        {
            Command cmd = new Command("SP_UpdatePerson", true);
            cmd.AddParameters("Id", entity.Id);
            cmd.AddParameters("FirstName", entity.FirstName);
            cmd.AddParameters("LastName", entity.LastName);
            cmd.AddParameters("Email", entity.Email);
            cmd.AddParameters("Password", entity.Password);
            cmd.AddParameters("RoleId", entity.RoleId);
            _connection.ExecuteNonQuery(cmd);

        }
    }
}
