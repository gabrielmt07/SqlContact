using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SC.API.Domain
{
    public class Curso
    {
        [Key]
        public int IdCurso { get; set; }

        [Required(ErrorMessage = "{0} é necessário!")]
        public string NomeCurso { get; set; }

        [Required(ErrorMessage = "{0} é necessário!")]
        public DateTime DataCadastroCurso { get; set; }

        [Required(ErrorMessage = "{0} é necessário!")]
        public string LoginCadastroCurso { get; set; }
    }
}
