using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Classnotes.Models
{
    [Table("Pais")]
    public class Pais
    {
        [Key]
        public int Id { get; set; }


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
        
    }
}
