﻿using BlackGarlic.DAL.Interfaces.IPeopleRepos;
using BlackGarlic.DTO.Interfaces.IPeopleService;
using BlackGarlic.DTO.Models.People;
using BlackGarlic.DTO.Tools.PeopleMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackGarlic.DTO.Services.PeopleService
{
    public class PersonService : IPersonService
    {
        private IPersonRepository _repo;

        public PersonService(IPersonRepository repo)
        {
            _repo = repo;
        }

        public bool Delete(int id)
        {
            return _repo.Delete(id);
        }

        public IEnumerable<Person> GetAll()
        {
            return _repo.GetAll().Select(p => p.toDAL());
        }

        public Person GetById(int id)
        {
            return _repo.GetOne(id).toDAL();
        }

        public Person GetPersonByMail(string mail)
        {
            return _repo.GetPersonByMail(mail).toDAL();
        }

        public IEnumerable<Person> GetPersonByName(string name)
        {
            return _repo.GetPersonByName(name).Select(p => p.toDAL());
        }

        public int Insert(Person entity)
        {
            return _repo.Insert(entity.toDTO());
        }

        public void Update(Person entity)
        {
            _repo.Update(entity.toDTO());
        }
    }
}