using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eloise.Models
{
    public class EloiseContext:DbContext
    {
        public EloiseContext(DbContextOptions<EloiseContext> options)
            : base(options)
        {
        }

        public DbSet<Receita> Receita { get; set; }
        public DbSet<Passo> Passo { get; set; }

        public DbSet<Ingrediente> Ingrediente { get; set; }
        public DbSet<IngredienteReceita> IngredienteReceita { get; set; }

        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IngredienteReceita>()
                        .HasKey(t => new { t.id_ingrediente, t.id_receita });

            modelBuilder.Entity<IngredienteReceita>()
                        .HasOne(t => t.Receita)
                        .WithMany(t => t.ingredientes)
                        .HasForeignKey(t => t.id_receita);
            
            modelBuilder.Entity<IngredienteReceita>()
                        .HasOne(t => t.Ingrediente)
                        .WithMany(t => t.Receitas)
                        .HasForeignKey(t => t.id_ingrediente);
            
            modelBuilder.Entity<Passo>()
                        .HasKey(t => new { t.receitaid, t.passo });

                        
        }
    }
}
