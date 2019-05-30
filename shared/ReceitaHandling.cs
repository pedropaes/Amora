using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Eloise.Models;
using Microsoft.EntityFrameworkCore;

namespace Eloise.shared
{
    public class ReceitaHandling
    {
        private readonly EloiseContext _context;
        public ReceitaHandling(EloiseContext context)
        {
            _context = context;
        }

        /*
        public Receita getRecipe(string ingrediente)
        {
           Receita r = _context.Receita.Where(b => b.descricao.Equals(ingrediente));
           return r;
        }
        */
        public Receita[] getReceitas()
        {
            return _context.Receita.ToArray();
        }
        public Receita getReceita(int id)
        {
            var recipe = _context.Receita.Find(id);

            var passos = _context.Passo.Where(s => s.receitaid == recipe.id);

            //IEnumerable <Ingrediente> ingredientes = _context.ingredientes.Where(ri => ri.ingrediente.receita.id == recipe.id).Select(i => i.ingrediente);
            //recipe.ingredientex = _context.Ingredientes.Where(ri => ri.receita.id == recipe.id).Select(i => i.ingrediente);
            //Debug.Print(ingredientes.Count().ToString());
            foreach (Passo t in passos)
            {
                recipe.passos.Add(t);
            }
            
        /*
            foreach (Ingrediente i in ingredientes)
            {
                recipe.ingredientex.Add(i);
            }
            */
            return recipe;

        }
    }
}