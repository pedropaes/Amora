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

        public ValorNutricional Valor { set; get; }

        public int dose { set; get; }

        public double classificacao { set; get; }

        public string imagem { set; get; }


        public Dictionary<int, Passo> Passos { get; set; }

        public Dictionary<Ingrediente, string> Ingredientes { get; set; }

        public List<Alergenio> Alergenios { get; set; }
    }
}
