using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        public virtual ICollection<Favoritos> Favoritos { get; set; }

        [NotMapped]
        [JsonIgnore]
        public virtual List<Receita> Receitas { get; set; }


    }

}
