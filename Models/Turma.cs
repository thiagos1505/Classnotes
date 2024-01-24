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

        [Required(ErrorMessage = "O campo nome é obrigatório")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "O campo turno é obrigatório")]
        public Turno turno { get; set; }

        [Required(ErrorMessage = "O campo ano é obrigatório")]
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

