using Microsoft.AspNetCore.Mvc;
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
        [Route("login")]
        public string Login()
        {
            return "hola mundo";
        }

        //[HttpPost]
        //[Route("login")]
        //public  async Task<ActionResult<User>> Login(User body)
        //{
        //    //User user = new User();
        //    //user.Name = body.Name;

        //    ////falta el await

        //    //return  Ok(user);
        //}

        //[HttpPost]
        //[Route("logOut")]
        //public async Task<ActionResult<User>> LogOut(User body)
        //{
        //    //User user = new User();
        //    //user.Name = body.Name;

        //    ////falta el await

        //    //return  Ok(user);
        //}


        //[HttpPost]
        //[Route("signin")]
        //public IActionResult SigIn(User body)
        //{
        //    return Ok(new User());
        //}

        //[HttpPost]
        //[Route("signOut")]
        //public IActionResult SigOut(User body)
        //{
        //    return Ok(new User());
        //}



    }
}
