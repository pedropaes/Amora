using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Eloise.Models;
using Eloise.shared;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;


namespace Eloise.Controllers
{
    [Route("[controller]/[action]")]
    public class ReceitaViewController : Controller
    {

        private ReceitaHandling receitaHandling;
        public ReceitaViewController(ReceitaContext context)
        {
            //_context = context;
            receitaHandling = new ReceitaHandling(context);
        }

        public IActionResult getReceitas()
        {
            Receita[] receitas = receitaHandling.getReceitas();
            return View(receitas);
        }

        public IActionResult getReceita()
        {
            Receita receitas = receitaHandling.getReceita(1);
            return View(receitas);
        }

        [HttpGet]
        public IActionResult RegisterReceita()
        {
            return View();
        }

    }
}