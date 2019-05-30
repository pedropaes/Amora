using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Eloise.Models;

namespace Eloise.Controllers
{
    public class ReceitasController : Controller
    {
        private readonly EloiseContext _context;

        public ReceitasController(EloiseContext context)
        {
            _context = context;
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
            ReceitaViewModel rvm = new ReceitaViewModel();
            var receita = _context.Receita.Find(id);
            rvm.classificacao = receita.classificacao;
            rvm.descricao = receita.descricao;
            rvm.dificuldade = receita.dificuldade;
            rvm.dose = receita.dose;
            rvm.id = receita.id;
            rvm.imagem = receita.imagem;
            rvm.tempo = receita.tempo;
            rvm.valor = receita.valor;

            var ingredientes = _context.IngredienteReceita.Where(i => i.receitaid == id).Select(ri => ri.Ingrediente);

            foreach(Ingrediente i in ingredientes)
            {
                //Ingrediente ing = _context.Ingrediente.Where(ig => ig.id == i.id);
                rvm.Ingredientes = new Dictionary<int, Ingrediente>();
                rvm.Ingredientes.Add(i.id, i);
            }
            return rvm; 
        }

        public IActionResult GetReceita(int id)
        {
            ReceitaViewModel receita = GetReceitaById(id);
            return View("getReceita", receita);
        }
    }
}
