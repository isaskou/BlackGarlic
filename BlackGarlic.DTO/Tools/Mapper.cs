using BlackGarlic.DTO.Models.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackGarlic.DTO.Tools
{
    public static class Mapper
    {
        #region People


        public static DTO.Models.People.Customer CustomerDTOtoDAL(this DAL.Models.People.Customer c)
        {
            if (c == null) return null;
            return new Customer
            {
                Id = c.Id,
                CompanyName = c.CompanyName,
                PersonId = c.PersonId,
                Person=new Person(c.PersonId, "", "", "", "", "", new Role()),
                Phone = c.Phone
            };
        }

        public static DAL.Models.People.Customer CustomerDAOtoDTO(this DTO.Models.People.Customer c)
        {
            return new DAL.Models.People.Customer
            {
                Id = c.Id,
                CompanyName = c.CompanyName,
                PersonId = c.Person.Id,
                Phone = c.Phone
            };
        }

        public static DTO.Models.People.CustomerAdress CustomerAdressDTOtoDAL(this DAL.Models.People.CustomerAdress ca)
        {
            return new CustomerAdress
            {
                Id = ca.Id,
                CustomerId = ca.CustomerId,
                AdressId = ca.AdressId
            };
        }

        public static DAL.Models.People.CustomerAdress CustomerAdressDALtoDTO(this DAL.Models.People.CustomerAdress ca)
        {
            return new DAL.Models.People.CustomerAdress
            {
                Id = ca.Id,
                CustomerId = ca.CustomerId,
                AdressId = ca.AdressId
            };
        }

        public static DTO.Models.People.Person PersonDTOtoDAL(this DAL.Models.People.Person p)
        {
            return new Person
            {
                Id = p.Id,
                FirstName = p.FirstName,
                LastName = p.LastName,
                Email = p.Email,
                Password=p.Password,
                RoleId = p.RoleId
            };
        }
        public static DAL.Models.People.Person PersonDALtoDTO(this DAL.Models.People.Person p)
        {
            return new DAL.Models.People.Person
            {
                Id = p.Id,
                FirstName = p.FirstName,
                LastName = p.LastName,
                Email = p.Email,
                Password = p.Password,
                RoleId = p.RoleId
                
            };
        }

        public static DTO.Models.People.Provider ProviderDTOtoDAL(this DAL.Models.People.Provider p)
        {
            return new Provider
            {
                Id = p.Id,
                FirstName = p.FirstName,
                LastName = p.LastName,
                CompanyName = p.CompanyName,
                PhoneNumber = p.PhoneNumber,
                AdressId = p.AdressId
            };
        }

        public static DAL.Models.People.Provider ProviderDALtoDTO(this DAL.Models.People.Provider p)
        {
            return new DAL.Models.People.Provider
            {
                Id = p.Id,
                FirstName = p.FirstName,
                LastName = p.LastName,
                CompanyName = p.CompanyName,
                PhoneNumber = p.PhoneNumber,
                AdressId = p.AdressId
            };
        }

        public static DTO.Models.People.Role RoleDTOtoDAL(this DAL.Models.People.Role r)
        {
            return new DTO.Models.People.Role
            {
                Id = r.Id,
                Name = r.Name
            };
        }

        public static DAL.Models.People.Role RoleDALtoDTO(this DAL.Models.People.Role r)
        {
            return new DAL.Models.People.Role
            {
                Id = r.Id,
                Name = r.Name
            };
        }


        #endregion

        #region Products
        public static DTO.Models.Products.Product ProductDTOtoDAL(this DAL.Models.Products.Product p)
        {
            return new Models.Products.Product
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                IsDisabled = p.IsDisabled,
                UnitPrice = p.UnitPrice,
                PictureUrl = p.PictureUrl
            };
        }

        public static DAL.Models.Products.Product ProductDALtoDTO(this DAL.Models.Products.Product p)
        {
            if (p == null) return null;
            return new DAL.Models.Products.Product
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                IsDisabled = p.IsDisabled,
                UnitPrice = p.UnitPrice,
                CategoryProductId = p.CategoryProductId,
                ProviderId = p.ProviderId,
                PictureUrl = p.PictureUrl
            };
        }

        public static DTO.Models.Products.CategoryProduct CategoryDTOtoDAL(this DAL.Models.Products.CategoryProduct cp)
        {
            return new Models.Products.CategoryProduct
            {
                Id = cp.Id,
                Name = cp.Name,
                Description = cp.Description
            };
        }

        public static DAL.Models.Products.CategoryProduct CategoryDALtoDTO(this DAL.Models.Products.CategoryProduct cp)
        {
            return new DAL.Models.Products.CategoryProduct
            {
                Id = cp.Id,
                Name = cp.Name,
                Description = cp.Description
            };
        }
         


        #endregion

        #region Panier

        //TODO

        #endregion
    }
}
