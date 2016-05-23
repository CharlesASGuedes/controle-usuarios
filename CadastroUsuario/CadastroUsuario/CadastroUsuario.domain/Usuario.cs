using System;

namespace CadastroUsuario.Domain
{
    public class Usuario
    {
        public Guid Id { get; set; }         
        public string Nome { get; set; }        
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Telefone { get; set; }
        public string DDD { get; set; }
        public DateTime Data_Criacao { get; set; }
        public DateTime Data_Atualizacao { get; set; }
        public DateTime Ultimo_Login { get; set; }
        public string Token { get; set; }

        public Usuario()
        {
            this.Ultimo_Login =  Ultimo_Login;
        }
    }
}