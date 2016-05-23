using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CadastroUsuario.Models
{
    public class Usuario
    {
        public string Id { get; set; }

        [Required]
        [StringLength(100,ErrorMessage = "Nome é obrigatório")]
        public string Nome { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "E-mail em formato inválido")]
        public string Email { get; set; }

        [Required]
        [StringLength(8, ErrorMessage = "Senha é obrigatório")]
        public string Senha { get; set; }

        [Required]
        [StringLength(9, ErrorMessage = "Telefone é obrigatório")]
        public string Telefone { get; set; }

        [Required]
        [StringLength(3, ErrorMessage = "DDD é obrigatório")]
        public string DDD { get; set; }

        public DateTime Data_Criacao { get; set; }

        public DateTime Data_Atualizacao { get; set; }

        public DateTime Ultimo_Login { get; set; }

        public string Token { get; set; }
       
    }
}