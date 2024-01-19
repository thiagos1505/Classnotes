using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Classnotes.Models
{
    [Table("Professores")]
    public class Professor
    {
        [Key]
        public int IdProfessor { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "O campo sobrenome é obrigatório")]
        public string? Sobrenome { get; set; }

        [Required(ErrorMessage = "O campo email é obrigatório")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "O campo senha é obrigatório")]
        [DataType(DataType.Password)]
        public string? Senha { get; set; }

        [Required(ErrorMessage = "O campo cpf é obrigatório")]
        [Display(Name = "CPF")]
        [DisplayFormat(DataFormatString = "{0:###.###.###-##}")]
        public string? Cpf { get; set; }

        [Required(ErrorMessage = "O campo telefone é obrigatório")]
        [Display(Name = "Telefone")]
        [DisplayFormat(DataFormatString = "{0:(##) ####-####}")]
        public string? Telefone { get; set; }

        public int Turma { get; set; }


    }
}
