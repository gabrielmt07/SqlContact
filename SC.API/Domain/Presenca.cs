using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace SC.API.Domain
{
    public class Presenca
    {
        public int IdTurma { get; set; }

        public int IdAluno { get; set; }

        public int IdCurso { get; set; }

        [Required(ErrorMessage = "{0} é necessário!")]
        public DateTime DataInicio { get; set; }

        public DateTime DataTermino { get; set; }

        [Required(ErrorMessage = "{0} é necessário!")]
        public DateTime DataCadastroCurso { get; set; }

        public string LoginCadastroCurso { get; set; }
    }
}
