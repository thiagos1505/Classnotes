using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Classnotes.Models
{
    [Table("Alunos")]
    public class Aluno
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Você precisa informar o nome do aluno!")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "O sobrenome também")]
        public string? Sobrenome { get; set; }

        [Required(ErrorMessage = "Precisamos saber a data de nascimento!")]
        [Display(Name = "Data de Nascimento")]
        public string? DataNascimento { get; set; }

        public Turma Turma { get; set; }


    }
}
