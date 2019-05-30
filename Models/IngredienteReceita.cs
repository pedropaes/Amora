using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eloise.Models
{
    public class IngredienteReceita
    {
        
        [Key]
        public int ingredienteid { set; get; }

        [Key]
        public int receitaid { set; get; }

        public Receita Receita { set; get; }

        public Ingrediente Ingrediente { set; get; }


    }
}
