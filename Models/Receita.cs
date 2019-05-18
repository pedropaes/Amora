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

        [StringLength(50)]
        public string dificuldade { set; get; }

        [DataType(DataType.Time)]
        public TimeSpan tempo { set; get; }

        [StringLength(50)]
        public string valor { set; get; }

        [StringLength(50)]
        public string dose { set; get; }
    }

    public class ReceitaContext : DbContext
    {
        public ReceitaContext(DbContextOptions<ReceitaContext> options)
            : base(options)
        {
        }

        public DbSet<Receita> Receita { get; set; }
    }
}
