using BlackGarlic.DAL.Interfaces.IProductsRepos;
using BlackGarlic.DTO.Interfaces.IProductsServices;
using BlackGarlic.DTO.Models.Products;
using BlackGarlic.DTO.Tools.ProductsMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackGarlic.DTO.Services.ProductsServices
{
    public class CategoryService : ICategoryService
    {
        private ICategoryProductRepository _repo;

        public CategoryService(ICategoryProductRepository repo)
        {
            _repo = repo;
        }

        public bool Delete(int id)
        {
            return _repo.Delete(id);
        }

        public IEnumerable<CategoryProduct> GetAll()
        {
            return _repo.GetAll().Select(c => c.toDAL());
        }

        public CategoryProduct GetById(int id)
        {
            return _repo.GetOne(id).toDAL();
        }

        public CategoryProduct GetByName(string name)
        {
            return _repo.GetByName(name).toDAL();
        }

        public int Insert(CategoryProduct entity)
        {
            return _repo.Insert(entity.toDTO());
        }

        public void Update(CategoryProduct entity)
        {
             _repo.Update(entity.toDTO());
        }
    }
}
