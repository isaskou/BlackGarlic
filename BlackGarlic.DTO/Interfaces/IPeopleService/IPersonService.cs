using BlackGarlic.DTO.Interfaces.IServices;
using BlackGarlic.DTO.Models.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackGarlic.DTO.Interfaces.IPeopleService
{
    public interface IPersonService:IService<Person>
    {
        Person GetPersonByMail(string mail);
        IEnumerable<Person> GetPersonByName(string name);
    }
}
