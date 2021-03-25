using Microsoft.AspNetCore.Mvc;
using MyServiceWeb.Models;
using MyServiceWeb.Services;
using MyServiceWeb.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyServiceWeb.ModelResponse;


namespace MyServiceWeb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;

        public UserController(IUserService service) => _service = service;

        [HttpGet]
        //[Route("{id}")]
        public async Task<IActionResult> GetUser(long id) {

            IResponse response = await _service.Get(id);

            return  Ok(response); 
        }

        [HttpPost]
        [Route("Edit")]
        public async Task<IActionResult> EditUser(User user)
        {
            IResponse response = await _service.Edit(user);

            return Ok(response);
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
