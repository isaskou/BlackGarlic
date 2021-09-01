using BlackGarlic.DTO.Models.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackGarlic.DTO.Models.Caddies
{
    public class CommandDetail
    {
        public int Id { get; set; }
        public DateTime? DateOfCommand { get; set; }
        public Customer Customer { get; set; }
        public Adress Adress { get; set; }
        public List<CommandProduct> CommandProducts { get; set; }
    }
}
