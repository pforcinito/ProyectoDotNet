using Microsoft.AspNetCore.Mvc;
using MyServiceWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyServiceWeb.Services;
using MyServiceWeb.Interfaces;

namespace MyServiceWeb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostController : ControllerBase
    {
        private readonly IUserPostService _service;

        public PostController(IUserPostService service) => _service = service;

        [HttpGet]
        //[Route("{id}")]
        public async Task<IActionResult> GetPost(long id)
        {

            //long id = 5;
            //var users = await _context.Users.FindAsync(id);
            var user = await _service.Get(id);

            return Ok(user);

        }

    }
}
