using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackGarlic.DTO.Interfaces.IServices
{
    public interface IServiceForCommand<T> : IGetAllService<T>, IGetOneService<T>, IInsertService<T>, IUpdateService<T>, IDeleteService<T>
    {
    }

    public interface IGetAllService<T>
    {
        IEnumerable<T> GetAll();
    }

    public interface IGetOneService<T>
    {
        T GetOne(int Id);
    }

    public interface IInsertService<T>
    {
        int InsertCommand(T Value);
    }

    public interface IUpdateService<T>
    {
        bool Update(T Value);
    }

    public interface IDeleteService<T>
    {
        bool Delete(int Id);
    }

}
