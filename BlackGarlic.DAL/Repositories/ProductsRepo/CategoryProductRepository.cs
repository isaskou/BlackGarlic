using BlackGarlic.DAL.Interfaces.IProductsRepos;
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
    public class CategoryProductRepository : BaseRepository, ICategoryProductRepository
    {
        public CategoryProductRepository(IConfiguration config) : base(config)
        {
        }

        public bool Delete(int id)
        {
            Command cmd = new Command("DELETE FROM CategoryProduct WHERE Id=@Id", false);
            cmd.AddParameters("Id", id);
            return _connection.ExecuteNonQuery(cmd) == 1;
        }

        public IEnumerable<CategoryProduct> GetAll()
        {
            Command cmd = new Command("SP_GetAllCatgoryProduct", true);
            return _connection.ExecuteReader(cmd, Converter.CategoryConvert);
        }

        public CategoryProduct GetOne(int id)
        {
            Command cmd = new Command("SP_GetCategoryById", true);
            cmd.AddParameters("CategoryId", id);
            return _connection.ExecuteReader(cmd, Converter.CategoryConvert).FirstOrDefault();
        }

        public CategoryProduct GetByName(string name)
        {
            Command cmd = new Command("SP_GetCategoryProductByName", true);
            cmd.AddParameters("name", name);
            return _connection.ExecuteReader(cmd, Converter.CategoryConvert).FirstOrDefault();
        }

        public int Insert(CategoryProduct entity)
        {
            Command cmd = new Command("SP_AddCategoryProduct", true);
            cmd.AddParameters("Name", entity.Name);
            cmd.AddParameters("Description", entity.Description);

            return (int)_connection.ExecuteScalar(cmd);
        }

        public void Update(CategoryProduct entity)
        {
            Command cmd = new Command("SP_UpdateCategoryProduct", true);
            cmd.AddParameters("CategoryId", entity.Id);
            cmd.AddParameters("Name", entity.Name);
            cmd.AddParameters("Desccription", entity.Description);

            _connection.ExecuteNonQuery(cmd);
        }
    }
}
