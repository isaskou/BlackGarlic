using BlackGarlic.DTO.Interfaces.IPeopleService;
using BlackGarlic.DTO.Models.People;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TokenTools;

namespace BlackGarlic.API.Controllers.People
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        protected TokenManager _tokenManager;
        ICustomerService _customerService;

        public LoginController(TokenManager tokenManager, ICustomerService customerService)
        {
            _tokenManager = tokenManager;
            _customerService = customerService;
        }

        [HttpPost]
        public IActionResult Login([FromBody] Login dt)
        {
            try
            {
                if (dt?.Email == null || dt.Password == null) return BadRequest();

                Customer customerFound = _customerService.GetCustomerByMailAndPasswordMatch(dt.Email, dt.Password);

                if (customerFound == null) return StatusCode(StatusCodes.Status401Unauthorized);

                string token = "";

                if (customerFound != null)
                {
                    token = _tokenManager.GenerateToken(new TokenData()
                    {
                        UserId = customerFound.Id,
                        UserName = customerFound.Email,
                        Role = customerFound.Role.Name
                    });
                }

                return Ok(new { token });
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, new
                {
                    Method = "Login",
                    Message = ex.Message
                });
            }
        }
    }
}
