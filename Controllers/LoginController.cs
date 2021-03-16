using Microsoft.AspNetCore.Mvc;
using MyServiceWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyServiceWeb.Controllers
{
    [ApiController]
    [Route("/loginService")]
    public class LoginController : ControllerBase
    {

        [HttpGet]
        [Route("getUser")]
        public IActionResult GetUser()
        {
            User user = new User();
            user.Id = 1;
            user.Name = "Pablo";
            user.Surname = "Forcinito";
            user.Birthday = DateTime.Now;


            //return Ok(user);
            return StatusCode(400, user);
        }

        [HttpPost]
        [Route("login")]
        public IActionResult login( User body)
        {
            User user = new User();            
            user.Name = body.Name;

            return StatusCode(200, user);
        }
            

    }
}
