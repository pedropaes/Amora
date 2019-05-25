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
    }

    public class ReceitaContext : DbContext
    {
        public ReceitaContext(DbContextOptions<ReceitaContext> options)
            : base(options)
        {
        }


        public DbSet<Receita> Receita { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Passo>().HasKey(t => new { t.receitaid, t.id_ingrediente });


        }
        public DbSet<Models.Passo> passo { get; set; }
    }
}
