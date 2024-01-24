using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Classnotes.Models
{
    [Table("Alunos")]
    public class Aluno
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "O campo sobrenome é obrigatório")]
        public string? Sobrenome { get; set; }

        [Required(ErrorMessage = "O campo data de nascimento é obrigatório")]
        [Display(Name = "Data de Nascimento")]
        public string? DataNascimento { get; set; }

        public Turma Turma { get; set; }


    }
}
