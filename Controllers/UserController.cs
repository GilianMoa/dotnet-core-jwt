using System;
using dotnet_core_jwt.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using dotnet_core_jwt.Services;

namespace dotnet_core_jwt.Controllers
{
    public class UserController : ApiController
    {

        [HttpGet]
        [Route("Authenticate3")]
        [AllowAnonymous]
        public IActionResult Authenticate3()
        {
            var a = "";
            return Ok(a);
        }

        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public IActionResult Authenticate1([FromBody] User model)
        {
            var user = UserRepository.GetUser(model.UserName, model.Password);
            if (user == null)
                return NotFound();

            var token = TokenServices.GenerateToken(user);
            user.Password = null;

            return Ok(new
            {
                user = user,
                token = token
            });
        }
    }
}
