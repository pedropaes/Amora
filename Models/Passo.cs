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
        public int passo { set; get; }

        [Required]
        [StringLength(250)]
        public string tecnica { set; get; }

        
        public virtual Receita receita { set; get; }

    }
}
