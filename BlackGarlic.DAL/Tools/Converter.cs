using BlackGarlic.DAL.Models.Panier;
using BlackGarlic.DAL.Models.People;
using BlackGarlic.DAL.Models.Products;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackGarlic.DAL.Tools
{
    public static class Converter
    {
        #region People
        public static Adress AdressConvert(IDataReader reader)
        {
            return new Adress
            {
                Id = (int)reader["Id"],
                Street = reader["Street"].ToString(),
                Num = reader["Num"].ToString(),
                PostalCode = (int)reader["PostalCode"],
                City = reader["City"].ToString(),
                District = reader["District"].ToString()
            };
        }

        public static Customer CustomerConvert(IDataReader reader)
        {
            return new Customer
            {
                Id = (int)reader["Id"],
                CompanyName = reader["CompanyName"].ToString(),
                FirstName = reader["FirstName"].ToString(),
                LastName = reader["LastName"].ToString(),
                Email = reader["Email"].ToString(),
                RoleId = (int)reader["RoleId"],
                Phone = (int)reader["Phone"]
            };
        }

        public static CustomerAdress CustomerAdressConvert(IDataReader reader)
        {
            return new CustomerAdress
            {
                Id = (int)reader["Id"],
                CustomerId = (int)reader["CustomerId"],
                AdressId = (int)reader["AdressId"]
            };
        }

        public static Provider ProviderConvert(IDataReader reader)
        {
            return new Provider
            {
                Id = (int)reader["Id"],
                FirstName = reader["FirstName"].ToString(),
                LastName = reader["LastName"].ToString(),
                CompanyName = reader["CompanyName"].ToString(),
                PhoneNumber = (int)reader["PhoneNumber"],
                AdressId = (int)reader["AdressId"]
            };
        }

        public static Role RoleConvert(IDataReader reader)
        {
            return new Role
            {
                Id = (int)reader["Id"],
                Name = reader["Name"].ToString()
            };
        }
        #endregion

        #region Products
        public static Product ProductConvert(IDataReader reader)
        {
            return new Product
            {
                Id = (int)reader["Id"],
                Name = reader["Name"].ToString(),
                Description = reader["Description"].ToString(),
                Utilisation = reader["Utilisation"].ToString(),
                Ingredients = reader["Ingredients"].ToString(),
                IsDisabled = (bool)reader["IsDisabled"],
                UnitPrice = (decimal)reader["UnitPrice"],
                CategoryProductId = (int)reader["CategoryProductId"],
                //ProviderId = (int)reader["ProviderId"],
                PictureUrl = reader["PictureUrl"].ToString()
            };
        }

        public static CategoryProduct CategoryConvert(IDataReader reader)
        {
            return new CategoryProduct
            {
                Id = (int)reader["Id"],
                Name = reader["Name"].ToString(),
                Description = reader["Description"].ToString()
            };
        }

        #endregion

        #region Panier
        public static Command CommandConvert(IDataReader reader)
        {
            return new Command
            {
                Id = (int)reader["Id"],
                DateOfCommand = (DateTime)reader["DateOfCommand"],
                CustomerId = (int)reader["CustomerId"],
                CustommerAdressId=(int)reader["CustomerAdressId"]
            };
        }

        public static CommandProduct CommandProductConvert(IDataReader reader)
        {
            return new CommandProduct
            {
                Id = (int)reader["Id"],
                Quantity=(int)reader["Quantity"],
                ProductId=(int)reader["ProductId"],
                CommandId=(int)reader["CommandId"]
            };
        }

        public static ShipAmount ShipAmountConvert(IDataReader reader)
        {
            return new ShipAmount
            {
                Id = (int)reader["Id"],
                District = reader["District"].ToString(),
                Amount = (double)reader["Amount"]
            };
        }
        #endregion
    }
}
