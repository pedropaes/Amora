using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eloise.Models
{
    public class IngredienteAlergenio
    {
        [Key]
        public int id_Alergenio { get; set; }
        [Key]
        public int id_Ingrediente { get; set; }
        
        public Ingrediente Ingrediente { get; set; }
        public Alergenio Alergenio { get; set; }

    }
}
