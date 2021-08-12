using BlackGarlic.DTO.Interfaces.IProductsServices;
using BlackGarlic.DTO.Models.Products;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlackGarlic.API.Controllers.Products
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryService _service;

        public CategoryController(ICategoryService service)
        {
            _service = service;
        }

        // GET: api/<CategoryController>
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

        // GET api/<CategoryController>/5
        [HttpGet]
        [Route("api/Category/GetById/{id}")]
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

        // GET api/<CategoryController>/name
        [HttpGet]
        [Route("api/Category/GetByName/{name}")]

        public IActionResult GetByName(string name)
        {
            try
            {
                return Ok(_service.GetByName(name));
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


        // POST api/<CategoryController>
        [HttpPost]
        public IActionResult Post([FromBody] CategoryProduct cp)
        {
            try
            {
                return Ok(_service.Insert(cp));
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

        // PUT api/<CategoryController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] CategoryProduct cp)
        {
            try
            {
                if (cp == null) return BadRequest();
                if (id != cp.Id) return BadRequest();

                cp.Id = id;
                _service.Update(cp);
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

        // DELETE api/<CategoryController>/5
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
