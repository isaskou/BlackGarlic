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
    public class RoleRepository : BaseRepository, IRoleRepository
    {
        public RoleRepository(IConfiguration config) : base(config)
        {
        }

        public IEnumerable<Role> GetAll()
        {
            throw new NotImplementedException();
        }

        public Role GetOne(int id)
        {
            Command cmd = new Command("SP_GetRoleById", true);
            cmd.AddParameters("@Id", id);
            return _connection.ExecuteReader(cmd, Converter.RoleConvert).SingleOrDefault();
        }
    }
}
