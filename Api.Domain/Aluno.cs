using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SC.API.Domain
{
    public class Aluno
    {
        [Key]
        [Column("id_aluno")]
        public int IdAluno { get; set; }

        [Required(ErrorMessage = "{0} é necessário!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "{0} é necessário!")]
        [Column("data_nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "{0} é necessário!")]
        public char Sexo { get; set; }

        [Required(ErrorMessage = "{0} é necessário!")]
        [Column("data_cadastro")]
        public DateTime DataCadastroAluno { get; set; }

        [Required(ErrorMessage = "{0} é necessário!")]
        [Column("login_cadastro")]
        public string LoginCadastroAluno { get; set; }
    }
}
