using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Eloise.Models
{
    public class Passo
    {
        [Key]
        public int id_receita { set; get; }

        [Key]
        public int id_ingrediente { set; get; }
        [Required]
        [StringLength(250)]
        public string tecnica { set; get; }
        [Required]
        [Range(0, float.MaxValue, ErrorMessage = "Please enter valid float Number")]
        public float data { set; get; }
    }
}
