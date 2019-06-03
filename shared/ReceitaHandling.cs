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

        public void getAlergenios(ReceitaViewModel rvm)
        {
            List<Alergenio> Alergenios = new List<Alergenio>();

            
            foreach (Ingrediente i in rvm.Ingredientes)
            {
                var aler = _context.IngredienteAlergenio.Where(b => b.id_Ingrediente == i.id).Select(ai => ai.Alergenio).FirstOrDefault();
                if (aler != null) Alergenios.Add(aler);
            }
            rvm.Alergenios = Alergenios;
        }
        public ReceitaViewModel ReceitaToReceitaCompleta(Receita receita)
        {
            ReceitaViewModel rvm = new ReceitaViewModel();
            rvm.classificacao = receita.classificacao;
            rvm.descricao = receita.descricao;
            rvm.dificuldade = receita.dificuldade;
            rvm.dose = receita.dose;
            rvm.id = receita.id;
            rvm.imagem = receita.imagem;
            rvm.tempo = receita.tempo;
            rvm.regime = receita.regime;
            rvm.tipo = receita.tipo;
            rvm.valor = receita.valor;

            rvm.Ingredientes = _context.IngredienteReceita.Where(i => i.id_receita == receita.id).Select(ri => ri.Ingrediente).ToList();

            var passos = _context.Passo.Where(s => s.receitaid == receita.id);
            rvm.Passos = new Dictionary<int, Passo>();

            foreach (Passo p in passos)
            {
                
                rvm.Passos.Add(p.passo, p);
            }

            getAlergenios(rvm);
            return rvm;

        }
        
        public List<ReceitaViewModel> ReceitastoReceitasCompletas(List<Receita> receitas)
        {
            List<ReceitaViewModel> rvms = new List<ReceitaViewModel>();
            foreach(Receita r in receitas)
            {
               rvms.Add(ReceitaToReceitaCompleta(r));
            }

            return rvms;
        }

        

   
        }
    }