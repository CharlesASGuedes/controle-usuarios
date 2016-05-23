using CadastroUsuario.Domain;
using CadastroUsuario.Infra.Mapping;
using System.Data.Entity;

namespace CadastroUsuario.Infra.DataContexts
{
    public class CadastroUsuarioDataContext : DbContext
    {
        public CadastroUsuarioDataContext() : base("CadastroUsuarioDataContext")
        {
            //Database.SetInitializer<CadastroUsuarioDataContext>(new CadastroUsuarioDataContextInitializer());
        }

        public IDbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UsuarioMap());
            base.OnModelCreating(modelBuilder);
        }
    }

    //public class CadastroUsuarioDataContextInitializer : DropCreateDatabaseIfModelChanges<CadastroUsuarioDataContext>
    //{
    //    protected override void Seed(CadastroUsuarioDataContext context)
    //    {
    //        context.Usuarios.Add(new Usuario { Nome = "Pedro", Email = "pedro@gmail.com",Telefone = "38381111",DDD="12", Senha = "123456", Ultimo_Login = System.DateTime.Now, Data_Criacao = System.DateTime.Now, Data_Atualizacao = System.DateTime.Now ,Token = "1"});
    //        context.Usuarios.Add(new Usuario { Nome = "Paulo", Email = "paulo@gmail.com", Telefone = "38382222", DDD = "12", Senha = "123456", Ultimo_Login = System.DateTime.Now, Data_Criacao = System.DateTime.Now, Data_Atualizacao = System.DateTime.Now, Token = "2" });
    //        context.Usuarios.Add(new Usuario { Nome = "Fernando", Email = "fernando@gmail.com", Telefone = "38383333", DDD = "12", Senha = "123456", Ultimo_Login = System.DateTime.Now, Data_Criacao = System.DateTime.Now, Data_Atualizacao = System.DateTime.Now, Token = "3" });
    //        context.Usuarios.Add(new Usuario { Nome = "Maria", Email = "maria@gmail.com", Telefone = "38384444", DDD = "12", Senha = "123456", Ultimo_Login = System.DateTime.Now, Data_Criacao = System.DateTime.Now, Data_Atualizacao = System.DateTime.Now, Token = "4" });
    //        context.Usuarios.Add(new Usuario { Nome = "Andreia", Email = "andreia@gmail.com", Telefone = "38385555", DDD = "12", Senha = "123456", Ultimo_Login = System.DateTime.Now, Data_Criacao = System.DateTime.Now, Data_Atualizacao = System.DateTime.Now, Token = "5" });
    //        context.Usuarios.Add(new Usuario { Nome = "Bruna", Email = "bruna@gmail.com", Telefone = "38386666", DDD = "12", Senha = "123456", Ultimo_Login = System.DateTime.Now, Data_Criacao = System.DateTime.Now, Data_Atualizacao = System.DateTime.Now, Token = "6" });

    //        context.SaveChanges();
    //    }
    //}
}
