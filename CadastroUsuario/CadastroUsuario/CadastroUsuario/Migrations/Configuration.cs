namespace CadastroUsuario.Migrations
{
    using Models;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<CadastroUsuarioDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CadastroUsuarioDataContext context)
        {
            context.Usuarios.Add(new Usuario { Id = "345bcc62-5d06-40ed-a464-4696d63fd579", Nome = "Pedro", Email = "pedro@gmail.com", Telefone = "38381111", DDD = "12", Senha = "123456", Ultimo_Login = System.DateTime.Now, Data_Criacao = System.DateTime.Now, Data_Atualizacao = System.DateTime.Now, Token = "1" });
            context.Usuarios.Add(new Usuario { Id = "3c5310bc-c25d-4591-a0c1-bb2195620a5e", Nome = "Paulo", Email = "paulo@gmail.com", Telefone = "38382222", DDD = "12", Senha = "123456", Ultimo_Login = System.DateTime.Now, Data_Criacao = System.DateTime.Now, Data_Atualizacao = System.DateTime.Now, Token = "2" });
            context.Usuarios.Add(new Usuario { Id = "cd761a90-b2b9-4ffb-a2e5-65a4864d723a", Nome = "Fernando", Email = "fernando@gmail.com", Telefone = "38383333", DDD = "12", Senha = "123456", Ultimo_Login = System.DateTime.Now, Data_Criacao = System.DateTime.Now, Data_Atualizacao = System.DateTime.Now, Token = "3" });
            context.Usuarios.Add(new Usuario { Id = "d87901d1-cbe7-4e0b-a2c4-684fbd798a94", Nome = "Maria", Email = "maria@gmail.com", Telefone = "38384444", DDD = "12", Senha = "123456", Ultimo_Login = System.DateTime.Now, Data_Criacao = System.DateTime.Now, Data_Atualizacao = System.DateTime.Now, Token = "4" });
            
            context.SaveChanges();
        }
    }
}
