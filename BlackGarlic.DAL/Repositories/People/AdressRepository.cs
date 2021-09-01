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
    public class AdressRepository : BaseRepository, IAdressRepository
    {
        public AdressRepository(IConfiguration config) : base(config)
        {
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Adress GetAdressByCustomerAdressId(int id)
        {
            Command cmd = new Command("SP_GetAdressByCustomerAdressId", true);
            cmd.AddParameters("CustomerAdressId", id);
            return _connection.ExecuteReader(cmd, Converter.AdressConvert).SingleOrDefault();
        }

        public IEnumerable<Adress> GetAllAdressesByCustomerId(int id)
        {
            Command cmd = new Command("SP_GetAllAdressesByCustomerId", true);
            cmd.AddParameters("@id", id);
            return _connection.ExecuteReader(cmd, Converter.AdressConvert);
        }

        public IEnumerable<Adress> GetAll()
        {
            Command cmd = new Command("SP_GetAllAdresses", true);
            return _connection.ExecuteReader(cmd, Converter.AdressConvert);
        }

        public Adress GetOne(int id)
        {
            Command cmd = new Command("SP_GetAdressById", true);
            cmd.AddParameters("id", id);
            return _connection.ExecuteReader(cmd, Converter.AdressConvert).SingleOrDefault();
        }

        public int Insert(Adress entity)
        {
            Command cmd = new Command("SP_AddAdress", true);
            cmd.AddParameters("@Street", entity.Street);
            cmd.AddParameters("@Num", entity.Num);
            cmd.AddParameters("PostalCode", entity.PostalCode);
            cmd.AddParameters("City", entity.City);
            cmd.AddParameters("District", entity.District);

            return (int)_connection.ExecuteScalar(cmd);
        }

        public void Update(Adress entity)
        {
            Command cmd = new Command("SP_UpdateAdress", true);
            cmd.AddParameters("@Street", entity.Street);
            cmd.AddParameters("@Num", entity.Num);
            cmd.AddParameters("PostalCode", entity.PostalCode);
            cmd.AddParameters("City", entity.City);
            cmd.AddParameters("District", entity.District);

            _connection.ExecuteNonQuery(cmd);

        }
    }
}
