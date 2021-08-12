using BlackGarlic.DAL.Interfaces.IRepo;
using BlackGarlic.DAL.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackGarlic.DAL.Interfaces.IProductsRepos
{
    public interface IProductRepository : IRepository<Product, int>
    {
    }
}
