using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotec.Models
{
    public class Livro
    {
        [Key]
       public int LivroID { get; set; }
        public string? nome { get; set; }
        public string? escritor { get; set; }
        public string? editora { get; set; }
        public string? descricao { get; set; }
        public string?  idioma { get; set; }
        public string? imagem { get; set; }
        public bool reservado { get; set; }
        public bool ativo { get; set; }
    }
}