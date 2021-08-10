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
                PersonId = (int)reader["PersonId"],
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

        public static Person PersonConvert(IDataReader reader)
        {
            return new Person
            {
                Id = (int)reader["Id"],
                FirstName = reader["FirstName"].ToString(),
                LastName = reader["LastName"].ToString(),
                Email = reader["Email"].ToString(),
                RoleId = (int)reader["RoleId"]
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
                IsDisabled = (bool)reader["IsDisabled"],
                UnitPrice = (double)reader["UnitPrice"],
                CategoryProductId = (int)reader["CategoryProductId"],
                ProviderId = (int)reader["ProviderId"],
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
        public static Caddie CaddieConvert(IDataReader reader)
        {
            return new Caddie
            {
                Id = (int)reader["Id"],
                OrderDate = (DateTime)reader["OrderDate"],
                CustomerId = (int)reader["CustomerId"],
                ShipAmountId = (int)reader["ShipAmountId"],
                TotalCaddie = (double)reader["TotalCaddie"]
            };
        }

        public static CaddieLine CaddieLineConvert(IDataReader reader)
        {
            return new CaddieLine
            {
                Id = (int)reader["Id"],
                ProductId = (int)reader["ProductId"],
                Quantity = (int)reader["Quantity"],
                TVAAmountId = (int)reader["TVAAmountId"],
                SubTotal = (double)reader["SubTotal"],
                CaddieId = (int)reader["CaddieId"]
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

        public static TVAAmount TVAAmountConvert(IDataReader reader)
        {
            return new TVAAmount
            {
                Id = (int)reader["Id"],
                TVAType = (double)reader["TVAType"]
            };
        }

        #endregion
    }
}
