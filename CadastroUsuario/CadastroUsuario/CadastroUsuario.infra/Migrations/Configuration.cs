namespace CadastroUsuario.infra.Migrations
{
    using Domain;
    using Infra.DataContexts;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CadastroUsuarioDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CadastroUsuarioDataContext context)
        {
            context.Usuarios.Add(new Usuario { Nome = "Pedro", Email = "pedro@gmail.com", Telefone = "38381111", DDD = "12", Senha = "123456", Ultimo_Login = System.DateTime.Now, Data_Criacao = System.DateTime.Now, Data_Atualizacao = System.DateTime.Now, Token = "1" });
            context.Usuarios.Add(new Usuario { Nome = "Paulo", Email = "paulo@gmail.com", Telefone = "38382222", DDD = "12", Senha = "123456", Ultimo_Login = System.DateTime.Now, Data_Criacao = System.DateTime.Now, Data_Atualizacao = System.DateTime.Now, Token = "2" });
            context.Usuarios.Add(new Usuario { Nome = "Fernando", Email = "fernando@gmail.com", Telefone = "38383333", DDD = "12", Senha = "123456", Ultimo_Login = System.DateTime.Now, Data_Criacao = System.DateTime.Now, Data_Atualizacao = System.DateTime.Now, Token = "3" });
            context.Usuarios.Add(new Usuario { Nome = "Maria", Email = "maria@gmail.com", Telefone = "38384444", DDD = "12", Senha = "123456", Ultimo_Login = System.DateTime.Now, Data_Criacao = System.DateTime.Now, Data_Atualizacao = System.DateTime.Now, Token = "4" });
            context.Usuarios.Add(new Usuario { Nome = "Andreia", Email = "andreia@gmail.com", Telefone = "38385555", DDD = "12", Senha = "123456", Ultimo_Login = System.DateTime.Now, Data_Criacao = System.DateTime.Now, Data_Atualizacao = System.DateTime.Now, Token = "5" });
            context.Usuarios.Add(new Usuario { Nome = "Bruna", Email = "bruna@gmail.com", Telefone = "38386666", DDD = "12", Senha = "123456", Ultimo_Login = System.DateTime.Now, Data_Criacao = System.DateTime.Now, Data_Atualizacao = System.DateTime.Now, Token = "6" });

            context.SaveChanges();
        }
    }
}
