using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Eloise.Models;
using Eloise.shared;

namespace Eloise.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {

        private readonly UserContext _context;
       
        public UserController(UserContext context)
        {
            _context = context;
        }

        [HttpGet]
        public User[] Get()
        {
            return _context.User.ToArray();
           
            
        }


        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var user = _context.User.Find(id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpPost]
        public IActionResult Add([FromBody] User user)
        {
            _context.User.Add(user);
            _context.SaveChanges();
            return new CreatedResult($"/api/user/{user.id}", user);
        }

        [HttpDelete]
        public IActionResult Delete([FromQuery] int id)
        {
            var user = _context.User.Find(id);

            if (user == null)
            {
                return NotFound();
            }
            _context.User.Remove(user);
            _context.SaveChanges();
            return NoContent();
        }
    }
}