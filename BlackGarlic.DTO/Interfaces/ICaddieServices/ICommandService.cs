using BlackGarlic.DTO.Interfaces.IServices;
using BlackGarlic.DTO.Models.Caddies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackGarlic.DTO.Interfaces.ICaddieServices
{
    public interface ICommandService : IInsertService<Command>, IGetOneService<CommandDetail>, IGetAllService<Command>
    {
    }
}
