using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SC.API.Domain
{
    public class Turma
    {
        [Key]
        public int IdTurma { get; set; }

        public int IdAluno { get; set; }

        public int IdCurso { get; set; }

        [Required(ErrorMessage = "{0} é necessário!")]
        public DateTime DataInicio { get; set; }

        public DateTime DataTermino { get; set; }

        [Required(ErrorMessage = "{0} é necessário!")]
        public DateTime DataCadastroTurma { get; set; }

        [Required(ErrorMessage = "{0} é necessário!")]
        public string LoginCadastroTurma { get; set; }
    }
}
