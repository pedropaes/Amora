using Microsoft.EntityFrameworkCore;
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

        public int receitaid { set; get; }

        [Key]
        public int ingredienteid { set; get; }
        [Required]
        [StringLength(50)]
        public string quantidade { set; get; }
        [Required]
        [StringLength(250)]
        public string tecnica { set; get; }

        [Required]
        public int numero { set; get; }
        public virtual Receita receita { set; get; }

    }
}
