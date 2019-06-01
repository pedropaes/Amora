using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eloise.Models
{
    public class Alergenio
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string nome { get; set; }

        public virtual ICollection<IngredienteAlergenio> Ingredientes { set; get; }
    }
}
