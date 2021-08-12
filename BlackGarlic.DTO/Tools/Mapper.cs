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

         


        #endregion

        #region Panier

        //TODO

        #endregion
    }
}
