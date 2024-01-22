using System.ComponentModel.DataAnnotations;

namespace Classnotes.Models
{
    public class Turma
    {
        [Key]
        public int Id { get; set; }
        public string? Nome { get; set; }

        public string? Turno { get; set; }

        public int Ano { get; set; }

        public Professor Professor { get; set; }
    }
}
