using BlackGarlic.DAL.Interfaces;
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

        public ProductService(IProductRepository productRepo)
        {
            _productRepo = productRepo;
        }

        public bool Delete(int id)
        {
            return _productRepo.Delete(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return _productRepo.GetAll().Select(p => p.toDTO());
        }

        public Product GetById(int id)
        {
            return _productRepo.GetOne(id).toDTO();
        }

        public int Insert(Product entity)
        {
            return _productRepo.Insert(entity.toDAL());
        }

        public void Update(Product entity)
        {
            _productRepo.Update(entity.toDAL());
        }
    }
}
