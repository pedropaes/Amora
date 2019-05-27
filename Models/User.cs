using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eloise.Models
{
    public class User
    {
        [Key]
        public int id { set; get; }
        [Required]
        [StringLength(50)]
        public string nome { set; get; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string email { set; get; }
        [Required]
        [DataType(DataType.Password)]
        public string password { set; get; }

        [StringLength(50)]
        public string regime { set; get; }

       
        [StringLength(50)]
        public string tipo { set; get; }

        //public virtual ICollection<Receita> favoritos { get; set; }

    }

    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        {

        }


        public DbSet<User> User { get; set; }
        public DbSet<User> Receita { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          


        }
    }
}
