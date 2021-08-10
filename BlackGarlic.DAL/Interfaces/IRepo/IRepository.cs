using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackGarlic.DAL.Interfaces.IRepo
{
    public interface IRepository<Tentity, Tid> :
    IInsertRepository<Tentity, Tid>,
    IGetAllRepository<Tentity>,
    IGetOneRepository<Tentity, Tid>,
    IUpdateRepository<Tentity>,
    IDeleteRepository<Tid>


    where Tentity : class
    where Tid : struct
    {

    }

    public interface IGetAllRepository<Tentity> where Tentity : class
    {
        IEnumerable<Tentity> GetAll();
    }

    public interface IGetOneRepository<Tentity, Tid>
    where Tentity : class
    where Tid : struct
    {
        Tentity GetOne(Tid id);

    }

    public interface IUpdateRepository<Tentity> where Tentity : class
    {
        void Update(Tentity entity);

    }

    public interface IDeleteRepository<Tid> where Tid : struct
    {
        bool Delete(Tid id);

    }

    public interface IInsertRepository<Tentity, Tid>
    where Tentity : class
    where Tid : struct
    {
        Tid Insert(Tentity entity);

    }
}
