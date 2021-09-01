using BlackGarlic.DAL.Interfaces.ICaddieRepos;
using BlackGarlic.DAL.Interfaces.IPeopleRepos;
using BlackGarlic.DAL.Interfaces.IProductsRepos;
using BlackGarlic.DTO.Interfaces.ICaddieServices;
using BlackGarlic.DTO.Models.Caddies;
using BlackGarlic.DTO.Tools.CaddieMapper;
using BlackGarlic.DTO.Tools.PeopleMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackGarlic.DTO.Services.CaddieService
{
    public class CommandService : ICommandService
    {
        private ICommandRepository _commandRepo;
        private ICustomerRepository _customerRepo;
        private IAdressRepository _adressRepo;
        private IProductRepository _productRepo;

        public CommandService(ICommandRepository commandRepo, ICustomerRepository customerRepo, IAdressRepository adressRepo, IProductRepository productRepo)
        {
            _commandRepo = commandRepo;
            _customerRepo = customerRepo;
            _adressRepo = adressRepo;
            _productRepo = productRepo;
        }

        public IEnumerable<Command> GetAll()
        {
            throw new NotImplementedException();
        }

        public CommandDetail GetOne(int Id)
        {
            CommandDetail cd = new CommandDetail();
            Command cmd = _commandRepo.GetOne(Id).toDAL();
            cd.DateOfCommand = cmd.DateOfCommand;
            cd.Adress = _adressRepo.GetAdressByCustomerId(cmd.CustommerAdressId).toDAL();
            cd.Customer = _customerRepo.GetOne(cmd.CustomerId).toDAL();
            cd.CommandProducts = _commandRepo.GetAllCommandProductByCommandId(Id).Select(x => x.toDAL()).ToList();
            
            foreach(CommandProduct cp in cd.CommandProducts)
            {
                cp.ProductName = _productRepo.GetOne(cp.ProductId).Name;
                cp.ProductPrice = _productRepo.GetOne(cp.ProductId).UnitPrice;
            };
            return cd;
        }

        public int InsertCommand(Command Value)
        {
            int commandId = _commandRepo.Insert(Value.toDTO());
            if (commandId > 0)
            {
                foreach (CommandProduct cp in Value.CommandProducts)
                {
                    cp.CommandId = commandId;
                    _commandRepo.InsertCommandProduct(cp.toDTO());
                }
            }
            return commandId;
        }

        public int InsertCommandProduct(CommandProduct Value)
        {
            return _commandRepo.InsertCommandProduct(Value.toDTO());
        }
    }
}
