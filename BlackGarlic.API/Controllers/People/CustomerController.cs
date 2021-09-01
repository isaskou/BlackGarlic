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
        //Ajouter le token

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }


        // GET: api/<CustomerController>
        [HttpGet]
        [Route("api/Customer/GetAll")]
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
        [HttpGet]
        [Route("api/Customer/{id}")]

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
                    Message = ex
                });
            }
        }

        [HttpGet]
        [Route("api/Customer/FullDetails/{id}")]
        public IActionResult GetCustomerWithFullDetailsById(int id)
        {
            try
            {
                return Ok(_customerService.GetCustomerWithAllInformationById(id));
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, new
                {
                    Method = "GetOneWithDetails",
                    Message = ex
                });
            }

        }

        // POST api/<CustomerController>
        [HttpPost]
        public IActionResult Post([FromBody] Customer c)
        {
            try
            {
                if(_customerService.FindEmail(c.Email, c.Id))
                {
                    return Ok("cet email existe déjà");
                }

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
                if(_customerService.FindEmail(customer.Email, customer.Id))
                {
                    return Ok("Cet email existe déjà");
                }
                //rajouter le token
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
