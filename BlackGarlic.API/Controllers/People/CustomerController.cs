using BlackGarlic.DTO.Interfaces.IPeopleService;
using BlackGarlic.DTO.Models.People;
using Microsoft.AspNetCore.Authorization;
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
    //[Authorize(Roles = "Client")]
    public class CustomerController : ControllerBase
    {
        ICustomerService _customerService;
        IPersonService _personService;

        public CustomerController(ICustomerService customerService, IPersonService personService)
        {
            _customerService = customerService;
            _personService = personService;
        }


        // GET: api/<CustomerController>
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_customerService.GetAll());

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

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                return Ok(_customerService.GetById(id));
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

        // POST api/<CustomerController>
        [HttpPost]
        public IActionResult Post([FromBody] Customer c)
        {
            try
            {
                return Ok(_customerService.Insert(c));
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

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Customer customer)
        {
            try
            {
                if (customer is null) return BadRequest();
                if (id != customer.Id) return BadRequest();

                customer.Id = id;
                _customerService.Update(customer);
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

        // DELETE api/<CustomerController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
