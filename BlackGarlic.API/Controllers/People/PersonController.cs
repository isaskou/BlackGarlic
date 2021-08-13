using BlackGarlic.DTO.Interfaces.IPeopleService;
using BlackGarlic.DTO.Models.People;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlackGarlic.API.Controllers.People
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        IPersonService _service;

        public PersonController(IPersonService service)
        {
            _service = service;
        }

        // GET: api/<PersonController>
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_service.GetAll());
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, new
                {
                    Method = "GetAll",
                    Message = ex.Message
                });
            }
        }

        [HttpGet]
        [Route("api_Person/GetByName/")]
        public IActionResult GetByName(string name)
        {
            try
            {
                return Ok(_service.GetPersonByName(name));
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, new
                {
                    Method = "GetByName",
                    Message = ex.Message
                });
            }
        }



        // GET api/<PersonController>/5
        [HttpGet]
        [Route("api/Person/GetById/{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                return Ok(_service.GetById(id));
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, new
                {
                    Method = "GetById",
                    Message = ex.Message
                });
            }

        }

        [HttpGet]
        [Route("api/Person/GetByMail/{mail}")]
        public IActionResult GetByMail(string mail)
        {
            try
            {
                return Ok(_service.GetPersonByMail(mail));
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, new
                {
                    Method = "GetByMail",
                    Message = ex.Message
                });
            }

        }



        // POST api/<PersonController>
        [HttpPost]
        public IActionResult Post([FromBody] Person p)
        {
            try
            {
                
                return Ok(_service.Insert(p));
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, new
                {
                    Method = "Post",
                    Message = ex.Message
                });
            }

        }

        // PUT api/<PersonController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Person p)
        {
            try
            {
                if (p == null) return BadRequest();
                if (id != p.Id) return BadRequest();

                p.Id = id;
                _service.Update(p);
                return Ok();
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, new
                {
                    Method = "Put",
                    Message = ex.Message
                });
            }

        }

        // DELETE api/<PersonController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                return Ok(_service.Delete(id));
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, new
                {
                    Method = "Delete",
                    Message = ex.Message
                });
            }

        }
    }
}
