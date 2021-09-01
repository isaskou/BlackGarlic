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

        public IEnumerable<Adress> GetAdressesByCustomerId(int id)
        {
            Command cmd = new Command("SP_GetAdressesForCustomer", true);
            cmd.AddParameters("@id", id);
            return _connection.ExecuteReader(cmd, Converter.AdressConvert);
        }

        public IEnumerable<Adress> GetAll()
        {
            throw new NotImplementedException();
        }

        public Adress GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Adress entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Adress entity)
        {
            throw new NotImplementedException();
        }
    }
}
