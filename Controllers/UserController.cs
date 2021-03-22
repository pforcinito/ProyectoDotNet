using Microsoft.AspNetCore.Mvc;
using MyServiceWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyServiceWeb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private  MyABMContext _context;
        public UserController(MyABMContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetUser(long id) {


            var user = _context.Users.Find(id);
            return Ok(user);
 
        }

        //[HttpGet]
        //[Route("getUser")]
        //public IActionResult GetUser()
        //{
        //    User user = new User();
        //    user.Id = 1;
        //    user.Name = "Pablo";
        //    user.Surname = "Forcinito";
        //    user.Birthday = DateTime.Now;

        //    return Ok(user);
        //    //return StatusCode(400, user);
        //}

        //[HttpGet]
        //[Route("getAllUser")]
        //public IActionResult GetUser()
        //{
        //    User user = new User();
        //    user.Id = 1;
        //    user.Name = "Pablo";
        //    user.Surname = "Forcinito";
        //    user.Birthday = DateTime.Now;

        //    return Ok(user);
        //    //return StatusCode(400, user);
        //}



        //[HttpPost]
        //[Route("modifyProfile")]
        //public async Task<ActionResult<User>> ModifyProfile(User body)
        //{
        //    //User user = new User();
        //    //user.Name = body.Name;

        //    ////falta el await

        //    //return  Ok(user);
        //}
    }
}
