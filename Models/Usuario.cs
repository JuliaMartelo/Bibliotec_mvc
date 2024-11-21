using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotec.Models
{
    public class Usuario
    {
        [Key]
        public int usuarioId { get; set; }
        public string? nome { get; set; }
        public DateOnly DtNascimento { get; set; }
        public string? email { get; set; }
        public string? senha { get; set; }
        public string? contato { get; set; }
        public bool admin { get; set; }
        public bool status { get; set; }

        //Criar um atributo
        //Eu falo para esse atributo que ele eh uma FK

        [ForeignKey("Curso")]
        public int  CursoIdd { get; set; }
        public Curso Curso{ get; set; }
    }
}