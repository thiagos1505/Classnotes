using Humanizer;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Classnotes.Models
{
    [Table("Turmas")]
    public class Turma
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome da turma!")]
        [Display(Name = "Nome da turma")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Precisamos saber o turno!")]
        public Turno Turno { get; set; }

        [Required(ErrorMessage = "E o ano também")]
        public int Ano { get; set; }

        [Display(Name = "Professor responsável")]
        public int ProfessorId { get; set; }
    }
}
    public enum Turno
    {
        Manha,
        Tarde
    }

