using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eloise.Models;
using Microsoft.EntityFrameworkCore;

namespace Eloise.shared
{
    public class ReceitaHandling
    {
        private readonly ReceitaContext _context;
        public ReceitaHandling(ReceitaContext context)
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

            var passos = _context.passo.Where(s => s.receitaid == recipe.id);
            foreach (Models.Passo t in passos)
            {
                recipe.passos.Add(t);
            }
            return recipe;

        }
    }
}