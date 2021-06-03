using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SC.API.Domain
{
    public class Situacao
    {
        [Key]
        public int IdSituacao { get; set; }

        [Required(ErrorMessage = "{0} é necessário!")]
        public string Status { get; set; }

        [Required(ErrorMessage = "{0} é necessário!")]
        public DateTime DataCadastroStatus { get; set; }

        [Required(ErrorMessage = "{0} é necessário!")]
        public string LoginCadastroStatus { get; set; }


    }
}
