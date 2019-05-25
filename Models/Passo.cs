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
        [StringLength(250)]
        public string tecnica { set; get; }

        public virtual Receita receita { set; get; }
    }
    public class PassoContext : DbContext
    {
        public PassoContext(DbContextOptions<PassoContext> options)
            : base(options)
        {
        }


        public DbSet<Passo> Receita { get; set; }


        public DbSet<Passo> Passo { get; set; }
    }
}
