using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotec.Models
{
    public class LivroCategoria
    {
        [Key]
        public int LivroCategoriaID { get; set; }
        public int LivroID { get; set; }


        [ForeignKey("Categoria")]
        public int CategoriaID { get; set;}
        public Categoria categoria{ get; set; }
    }
}