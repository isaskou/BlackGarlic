using BlackGarlic.DAL.Interfaces.IRepo;
using BlackGarlic.DAL.Models.Panier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackGarlic.DAL.Interfaces.ICaddieRepos
{
    public interface ICommandRepository : IRepository<Command, int>
    {
        int InsertCommandProduct(CommandProduct cl);

        IEnumerable<CommandProduct> GetAllCommandProductByCommandId(int id);
    }
}
