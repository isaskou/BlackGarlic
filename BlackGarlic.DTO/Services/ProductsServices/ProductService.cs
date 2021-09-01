using BlackGarlic.DAL.Interfaces;
using BlackGarlic.DAL.Interfaces.IProductsRepos;
using BlackGarlic.DTO.Interfaces;
using BlackGarlic.DTO.Interfaces.IProductsServices;
using BlackGarlic.DTO.Models.Products;
using BlackGarlic.DTO.Tools;
using BlackGarlic.DTO.Tools.ProductsMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackGarlic.DTO.Services.ProductsServices
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepo;
        private ICategoryProductRepository _categoryRepo;

        public ProductService(IProductRepository productRepo, ICategoryProductRepository categoryRepo)
        {
            _productRepo = productRepo;
            _categoryRepo = categoryRepo;
        }

        public bool Delete(int id)
        {
            return _productRepo.Delete(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return _productRepo.GetAll().Select(p => p.toDAL());
        }

        public Product GetById(int id)
        {
            Product result = null;
            result = _productRepo.GetOne(id).toDAL();
            if (result?.CategoryId != 0)
            {
                result.Category = _categoryRepo.GetOne(result.CategoryId).toDTO();
            }
            return result;
        }

        public IEnumerable<Product> GetProductsByCategoryId(int categoryId)
        {
            List<Product> ListOfProducts = new List<Product>();
            foreach (Product p in _productRepo.GetProductsByCategoryId(categoryId).Select(x=>x.toDAL()))
            {
                p.Category = _categoryRepo.GetOne(categoryId).toDTO();
                ListOfProducts.Add(p);
            }
            return ListOfProducts;
        }

        public int Insert(Product entity)
        {
            return _productRepo.Insert(entity.toDTO());
        }

        public void Update(Product entity)
        {
            _productRepo.Update(entity.toDTO());
        }
    }
}
