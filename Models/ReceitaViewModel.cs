using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eloise.Models
{
    public class ReceitaViewModel
    {
        public int id { set; get; }

        public string descricao { set; get; }


        public string regime { set; get; }


        public string tipo { set; get; }


        public string dificuldade { set; get; }

        public TimeSpan tempo { set; get; }

        public int valor { set; get; }


        public int dose { set; get; }

        public double classificacao { set; get; }

        public string imagem { set; get; }

        public Dictionary<Passo, Ingrediente> PassoIngredientes { get; set; }
        
        public Dictionary<int,Ingrediente> Ingredientes { get; set; }
    }
}
