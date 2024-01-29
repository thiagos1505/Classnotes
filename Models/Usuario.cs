using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Classnotes.Models
{

    [Table("Usuarios")]
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

        [Display(Name = "Tipo de Usuário")]
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

        [Required(ErrorMessage = "Precisamos saber a sua rua!")]
        public string? Rua { get; set; }

        [Required(ErrorMessage = "Precisamos saber o seu bairro tambem!")]
        public string? Bairro { get; set; }

        [Required(ErrorMessage = "Precisamos saber o número da sua casa!")]
        public int Numero { get; set; }

        public string? Complemento { get; set; }

        [Required(ErrorMessage = "Por favor informar a cidade!")]
        public string? Cidade { get; set; }

        [Required(ErrorMessage = "Por favor informar o estado!")]
        public string? Estado { get; set; }

        [Required(ErrorMessage = "Por favor informar o CEP!")]
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
