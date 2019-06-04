using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Eloise.Models
{
    public class Receita
    {
        [Key]
        public int id { set; get; }

        [Required]
        [StringLength(50)]
        public string descricao { set; get; }

        [Required]
        [StringLength(50)]
        public string regime { set; get; }

        [Required]
        [StringLength(50)]
        public string tipo { set; get; }

        [Required]
        [StringLength(50)]
        public string dificuldade { set; get; }

        [Required]
        [DataType(DataType.Time)]
        public TimeSpan tempo { set; get; }


        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        public int dose { set; get; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Please enter valid doubleNumber")]
        public double classificacao { set; get; }

        [Required]
        [StringLength(50)]
        public string imagem { set; get; }

        [Required]
        public int  Valor { set; get; }

        public virtual ICollection<Passo> passos { get; set; }

        public virtual ICollection<IngredienteReceita> ingredientes { get; set; }

        public virtual ICollection<Favoritos> Users { get; set; }



    }




    
}
    

