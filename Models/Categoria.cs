using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotec.Models
{
    public class Categoria
    {
        [Key]
        //atributos:
        //categoriaID
        //string nome

        public int categoriaID { get; set; }
        public string? nome { get; set; }
    }
}