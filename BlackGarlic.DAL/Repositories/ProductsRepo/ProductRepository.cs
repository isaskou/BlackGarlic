using BlackGarlic.DAL.Interfaces;
using BlackGarlic.DAL.Interfaces.IProductsRepos;
using BlackGarlic.DAL.Interfaces.IRepo;
using BlackGarlic.DAL.Models.Products;
using BlackGarlic.DAL.Repositories.Base;
using BlackGarlic.DAL.Tools;
using ConnectionTool;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BlackGarlic.DAL.Repositories.ProductsRepo
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(IConfiguration config) : base(config)
        {
        }

        public bool Delete(int id)
        {
            Command cmd = new Command("DELETE FROM Product WHERE Id=@Id", false);
            cmd.AddParameters("Id", id);
            return _connection.ExecuteNonQuery(cmd)==1;
        }

        public IEnumerable<Product> GetAll()
        {
            Command cmd = new Command("SP_GetAllProducts", true);

            return _connection.ExecuteReader(cmd, Converter.ProductConvert);
        }

        public Product GetOne(int id)
        {
            Command cmd = new Command("SP_GetProductById", true);
            cmd.AddParameters("productId", id);
            return _connection.ExecuteReader(cmd, Converter.ProductConvert).FirstOrDefault();
        }

        public IEnumerable<Product> GetProductsByCategoryId(int categoryId)
        {
            Command cmd = new Command("GetProductsByCategoryId" +
                "", true);
            cmd.AddParameters("@CategoryId", categoryId);
            return _connection.ExecuteReader(cmd, Converter.ProductConvert);
        }

        public int Insert(Product entity)
        {
            Command cmd = new Command("SP_AddProduct", true);
            cmd.AddParameters("Name", entity.Name);
            cmd.AddParameters("Description", entity.Description);
            cmd.AddParameters("Utilisation", entity.Utilisation);
            cmd.AddParameters("Ingredients", entity.Ingredients);
            cmd.AddParameters("IsDisabled", entity.IsDisabled);
            cmd.AddParameters("UnitPrice", entity.UnitPrice);
            cmd.AddParameters("CategoryProductId", entity.CategoryProductId);
            cmd.AddParameters("PictureUrl", entity.PictureUrl);

            return (int)_connection.ExecuteScalar(cmd);
        }

        public void Update(Product entity)
        {
            Command cmd = new Command("SP_UpdateProduct", true);
            cmd.AddParameters("ProductId", entity.Id);
            cmd.AddParameters("Name", entity.Name);
            cmd.AddParameters("Description", entity.Description);
            cmd.AddParameters("Utilisation", entity.Utilisation);
            cmd.AddParameters("Ingredients", entity.Ingredients);
            cmd.AddParameters("IsDisabled", entity.IsDisabled);
            cmd.AddParameters("UnitPrice", entity.UnitPrice);
            cmd.AddParameters("CategoryProductId", entity.CategoryProductId);
            cmd.AddParameters("PictureUrl", entity.PictureUrl);

            _connection.ExecuteNonQuery(cmd);

        }

    }
}
