using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eloise.Models
{
    public class Ingrediente
    {
        [Key]
        public int id { set; get; }

        [Required]
        [StringLength(50)]
        public string descricao { set; get; }


        public virtual ICollection<IngredienteReceita> Receitas { set; get; }
    }
}
