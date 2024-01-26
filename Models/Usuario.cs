using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Classnotes.Models
{

    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "É obrigatório informar o nome")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "É obrigatório informar o sobrenome")]
        public string? Sobrenome { get; set; }

        [Required(ErrorMessage = "É obrigatório informar o e-mail")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Você deve cadastrar uma senha!")]
        [DataType(DataType.Password)]
        public string? Senha { get; set; }

        [Required(ErrorMessage = "É opbrigatório informar seu CPF")]
        [Display(Name = "CPF")]
        [DisplayFormat(DataFormatString = "{0:###.###.###-##}")]
        public string? Cpf { get; set; }

        [Required(ErrorMessage = "Precisamos do seu telefone!")]
        [Display(Name = "Telefone")]
        [DisplayFormat(DataFormatString = "{0:(##) ####-####}")]
        public string? Telefone { get; set; }

        [Required(ErrorMessage = "Precisamos do seu endereço também!")]
        public Endereco EnderecoUsuario { get; set; }

        public TipoUsuario TipoUsuario { get; set; }

    }

    public enum TipoUsuario
    {
        Professor,
        Pais
    }

    public class Endereco
    {
        [Key]
        public int EnderecoId { get; set; }

        public string? Rua { get; set; }

        public string? Bairro { get; set; }

        public int Numero { get; set; }

        public string? Complemento { get; set; }

        public string? Cidade { get; set; }

        public string? Estado { get; set; }

        public string? Cep { get; set; }
    }

    public class Professor : Usuario
    {
        public int Turno { get; set; }

        public int Ano { get; set; }

        public string? Turma { get; set; }

    }

    public class Pais : Usuario
    {
        public string? Filho { get; set; }

    }

 }
