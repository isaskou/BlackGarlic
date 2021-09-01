using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackGarlic.DTO.Interfaces.IServices
{
    public interface IService<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        int Insert(T entity);
        void Update(T entity);
        bool Delete(int id);
    }

}
