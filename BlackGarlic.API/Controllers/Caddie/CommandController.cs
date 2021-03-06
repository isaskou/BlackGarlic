using BlackGarlic.DTO.Interfaces.ICaddieServices;
using BlackGarlic.DTO.Models.Caddies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlackGarlic.API.Controllers.Caddie
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class CommandController : ControllerBase
    {
        ICommandService _commandService;

        public CommandController(ICommandService commandService)
        {
            _commandService = commandService;
        }

        // GET api/<CommandController>/5
        [HttpGet]
        [Route("api/Command/{id}")]

        public IActionResult GetCommandById(int id)
        {
            try
            {
                return Ok(_commandService.GetOne(id));
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, new
                {
                    Method = "GetCommandById",
                    Message = ex.Message
                });
            }
        }

        // POST api/<CommandController>
        [HttpPost]
        [Route("api/Command/Insert")]

        public IActionResult InsertNewCommand([FromBody] Command cmd)
        {
            try
            {
                return Ok(_commandService.InsertCommand(cmd));
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, new
                {
                    Method = "InsertNewCommand",
                    Message = ex.Message
                });
            }
        }

        [HttpPost]
        [Route("api/Command/InsertCommandProduct")]

        public IActionResult InsertCommandProduct([FromBody]CommandProduct cp)
        {
            try
            {
                return Ok(_commandService.InsertCommandProduct(cp));
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, new
                {
                    Method = "InsertNewCommandProduct",
                    Message = ex.Message
                });
            }

        }
    }
}
