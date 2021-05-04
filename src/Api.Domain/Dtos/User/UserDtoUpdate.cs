using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.User
{
    public class UserDtoUpdate
    {
        [Required(ErrorMessage = "Nome é campo obrigatório.")]
        [StringLength(60, ErrorMessage = "Nome deve ter no máximo {1} caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Cpf é campo obrigatório.")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "E-mail é campo obrigatório.")]
        [EmailAddress(ErrorMessage = "E-mail inválido.")]
        [StringLength(100, ErrorMessage = "E-mail deve ter no máximo {1} caracteres.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telefone é campo obrigatório.")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Sexo é campo obrigatório.")]
        public string Sexo { get; set; }

        [Required(ErrorMessage = "Data Nascimento é campo obrigatório.")]
        public DateTime? DataNascimento { get; set; }
    }
}