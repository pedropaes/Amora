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
        public int valor { set; get; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        public int dose { set; get; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Please enter valid doubleNumber")]
        public double classificacao { set; get; }

        [Required]
        [StringLength(50)]
        public string imagem { set; get; }

        public virtual ICollection<Passo> passos { get; set; }

        public virtual ICollection<IngredienteReceita> ingredientes { get; set; }
        public virtual IEnumerable<Ingrediente> ingredientex { get; set; }


    }
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
    /*
    public class Ingrediente
    {
        [Key]
        public int id { set; get; }

        [Required]
        [StringLength(50)]
        public string descricao { set; get; }

        //[Required]
        //[StringLength(50)]
        //public string quantidade { set; get; }

        public virtual ICollection<IngredienteReceita> receitas { set; get; }
        
    }*/

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
    

