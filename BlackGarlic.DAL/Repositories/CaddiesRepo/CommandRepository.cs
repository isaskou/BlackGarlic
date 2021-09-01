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
            con.Command cmd = new con.Command("[GetAllCommandProductByCommandId]", true);
            cmd.AddParameters("CommandId", id);
            return _connection.ExecuteReader(cmd, Converter.CommandProductConvert);
        }

        public Command GetOne(int id)
        {
            con.Command cmd = new con.Command("GetCommandById", true);
            cmd.AddParameters("CommandId", id);
            return _connection.ExecuteReader(cmd, Converter.CommandConvert).FirstOrDefault();
        }

        public int Insert(Command entity)
        {
            con.Command cmd = new con.Command("InsertCommand", true);
            cmd.AddParameters("@DateOfCommand", entity.DateOfCommand);
            cmd.AddParameters("@CustomerId", entity.CustomerId);
            cmd.AddParameters("@CustomerAdressId", entity.CustommerAdressId);

            return (int)_connection.ExecuteScalar(cmd);
        }

        public int InsertCommandProduct(CommandProduct cl)
        {
            con.Command cmd = new con.Command("InsertCommandProduct", true);
            cmd.AddParameters("@Quantity", cl.Quantity);
            cmd.AddParameters("@ProductId", cl.ProductId);
            cmd.AddParameters("@CommandId", cl.CommandId);

            return _connection.ExecuteNonQuery(cmd);
        }

        public void Update(Command entity)
        {
            throw new NotImplementedException();
        }
    }

}
