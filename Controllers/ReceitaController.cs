using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Eloise.Models;

namespace Eloise.Controllers
{
    [Route("api/[controller]")]
    public class ReceitaController : Controller
    {

        private readonly ReceitaContext _context;

        public ReceitaController(ReceitaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public Receita[] Get()
        {
            return _context.Receita.ToArray();
        }


        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var receita = _context.Receita.Find(id);

            if (receita == null)
            {
                return NotFound();
            }

            return Ok(receita);
        }

        [HttpPost]
        public IActionResult Add([FromBody] Receita receita)
        {
            _context.Receita.Add(receita);
            _context.SaveChanges();
            return new CreatedResult($"/api/receita/{receita.id}", receita);
        }

        [HttpDelete]
        public IActionResult Delete([FromQuery] int id)
        {
            var receita = _context.Receita.Find(id);

            if (receita == null)
            {
                return NotFound();
            }
            _context.Receita.Remove(receita);
            _context.SaveChanges();
            return NoContent();
        }
    }
}