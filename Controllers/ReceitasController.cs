using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Eloise.Models;
using Eloise.shared;
using System.Security.Claims;

namespace Eloise.Controllers
{
    public class ReceitasController : Controller
    {
        private readonly EloiseContext _context;
        private ReceitaHandling handling;
        private UserHandling userhandling;

        public ReceitasController(EloiseContext context)
        {
            _context = context;
            handling = new ReceitaHandling(_context);
            userhandling = new UserHandling(_context);
        }

        // GET: Receitas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Receita.ToListAsync());
        }

        // GET: Receitas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var receita = await _context.Receita
                .FirstOrDefaultAsync(m => m.id == id);
            if (receita == null)
            {
                return NotFound();
            }

            return View(receita);
        }

        // GET: Receitas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Receitas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,descricao,regime,tipo,dificuldade,tempo,valor,dose,classificacao,imagem")] Receita receita)
        {
            if (ModelState.IsValid)
            {
                _context.Add(receita);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(receita);
        }

        // GET: Receitas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var receita = await _context.Receita.FindAsync(id);
            if (receita == null)
            {
                return NotFound();
            }
            return View(receita);
        }

        // POST: Receitas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,descricao,regime,tipo,dificuldade,tempo,valor,dose,classificacao,imagem")] Receita receita)
        {
            if (id != receita.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(receita);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReceitaExists(receita.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(receita);
        }

        // GET: Receitas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var receita = await _context.Receita
                .FirstOrDefaultAsync(m => m.id == id);
            if (receita == null)
            {
                return NotFound();
            }

            return View(receita);
        }

        // POST: Receitas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var receita = await _context.Receita.FindAsync(id);
            _context.Receita.Remove(receita);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReceitaExists(int id)
        {
            return _context.Receita.Any(e => e.id == id);
        }

        public ReceitaViewModel GetReceitaById(int id)
        {
            
            Receita receita = _context.Receita.Find(id);
            ReceitaHandling handling = new ReceitaHandling(_context);
            ReceitaViewModel rvm = handling.ReceitaToReceitaCompleta(receita);
            return rvm;
        }

        public List<ReceitaViewModel> GetReceitaByIngrediente(string ingrediente)
        {
            var ing_id = 0;
            List<ReceitaViewModel> rvms = new List<ReceitaViewModel>();
            
            Receita r = new Receita();
            ReceitaViewModel rvm = new ReceitaViewModel();
            //Procura id de Ingrediente
            foreach (Ingrediente i in _context.Ingrediente)
            {
                var val = i.descricao;
                if (val.Equals(ingrediente, StringComparison.InvariantCultureIgnoreCase))
                {
                    ing_id = i.id;
                    break;
                }
            }
            //Procura receitas que contêm o ingrediente
            foreach (IngredienteReceita ir in _context.IngredienteReceita)
            {
                if (ir.id_ingrediente == ing_id)
                {
                    r = _context.Receita.Find(ir.id_receita);

                    rvm = handling.ReceitaToReceitaCompleta(r);
                    rvms.Add(rvm);
                }
            }

            foreach (Receita rec in _context.Receita)
            {
                bool isContained = rec.descricao.IndexOf(ingrediente, StringComparison.OrdinalIgnoreCase) >= 0;
                if (isContained)
                {
                    rvm = handling.ReceitaToReceitaCompleta(rec);
                    rvms.Add(rvm);
                }
            }
            return rvms;
        }

        public IActionResult GetReceitas()
        {
            var all = _context.Receita.ToArray();
            List<Receita> receitas = all.ToList<Receita>();
            List<ReceitaViewModel> rvms;
            ReceitaViewModel rvm = new ReceitaViewModel();

            rvms = handling.ReceitastoReceitasCompletas(receitas);

            
            return View("Lista", rvms);
        }

        public IActionResult Favoritos()
        {
            var userId = User.FindFirst(ClaimTypes.Sid).Value;
            int id;
            if (string.IsNullOrEmpty(userId)) id = 1;


            int.TryParse(userId, out id);
            User u =  _context.User.Find(id);
            userhandling.getFavoritos(u);
            List<ReceitaViewModel> rvms;

            rvms = handling.ReceitastoReceitasCompletas(u.Receitas);


            return View("Lista", rvms);
        }

        public IActionResult GetReceitaByString(string keyword)
        {
            List<ReceitaViewModel> rvms = GetReceitaByIngrediente(keyword);


            return View("Lista", rvms);
        }

        public IActionResult GetReceita(int id)
        {
            ReceitaViewModel receita = GetReceitaById(id);
            return View("GetReceita", receita);
        }
    }
}
