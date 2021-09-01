using BlackGarlic.DTO.Models.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackGarlic.DTO.Models.Caddies
{
    public class Command
    {
        public int Id { get; set; }
        public DateTime? DateOfCommand { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int CustommerAdressId { get; set; }
        public CustomerAdress CustomerAdress { get; set; }
        public List<CommandProduct> CommandProducts { get; set; }

        public Command()
        {
        }

        public Command(int id, DateTime? dateOfCommand, int customerId, int custommerAdressId, List<CommandProduct> commandProducts)
        {
            Id = id;
            DateOfCommand = dateOfCommand;
            CustomerId = customerId;
            CustommerAdressId = custommerAdressId;
            CommandProducts = commandProducts;
        }
    }
}
