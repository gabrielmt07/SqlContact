using System;
using System.ComponentModel.DataAnnotations;

namespace SC.API.Domain
{
    public class Presenca
    {
        public int IdTurma { get; set; }

        public int IdAluno { get; set; }

        public int IdSituacao { get; set; }

        [Required(ErrorMessage = "{0} é necessário!")]
        public DateTime DataPresenca { get; set; }

        [Required(ErrorMessage = "{0} é necessário!")]
        public DateTime DataCadastroPresenca { get; set; }

        [Required(ErrorMessage = "{0} é necessário!")]
        public string LoginCadastroPresenca { get; set; }
    }
}
