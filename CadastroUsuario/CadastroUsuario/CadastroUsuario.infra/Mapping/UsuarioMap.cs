
using CadastroUsuario.Domain;
using System.Data.Entity.ModelConfiguration;

namespace CadastroUsuario.Infra.Mapping
{
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            ToTable("Usuario");
            HasKey(x => x.Id);

            Property(x => x.Nome).HasMaxLength(100).IsRequired();
            Property(x => x.Email).IsRequired().HasMaxLength(100);
            Property(x => x.Senha).IsRequired().HasMaxLength(8);
            Property(x => x.DDD).IsRequired().HasMaxLength(3);
            Property(x => x.Telefone).IsRequired().HasMaxLength(9);
            Property(x => x.Data_Criacao);
            Property(x => x.Data_Atualizacao);
            Property(x => x.Ultimo_Login);
            Property(x => x.Token);
            
        }
    }
}