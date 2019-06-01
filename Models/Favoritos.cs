using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eloise.Models
{
    public class Favoritos
    {
        [Key]
        public int id_Utilizador { get; set; }
        [Key]
        public int id_Receita { get; set; }

        public User User { set; get; }
        public Receita Receita { set; get; }

        
    }
}
