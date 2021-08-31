using BlackGarlic.DAL.Interfaces.ICaddieRepos;
using BlackGarlic.DAL.Models.Panier;
using BlackGarlic.DAL.Repositories.Base;
using con = ConnectionTool;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackGarlic.DAL.Tools;

namespace BlackGarlic.DAL.Repositories.CaddiesRepo
{
    public class CommandRepository : BaseRepository, ICommandRepository
    {
        public CommandRepository(IConfiguration config) : base(config)
        {
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CommandProduct> GetAllCommandProductByCommandId(int id)
        {
            con.Command cmd = new con.Command("GetAllCommandProductByCommandId", true);
            cmd.AddParameters("CommandId", id);
            return _connection.ExecuteReader(cmd, Converter.CommandProductConvert);
        }

        public Command GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Command entity)
        {
            throw new NotImplementedException();
        }

        public int InsertCommandProduct(CommandProduct cl)
        {
            throw new NotImplementedException();
        }

        public void Update(Command entity)
        {
            throw new NotImplementedException();
        }
    }

}
