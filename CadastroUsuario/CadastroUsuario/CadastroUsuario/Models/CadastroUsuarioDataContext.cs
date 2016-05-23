using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CadastroUsuario.Models
{
    public class CadastroUsuarioDataContext : DbContext
    {
        public CadastroUsuarioDataContext() : base("name=CadastroUsuarioDataContext")
        {
        }
        public IDbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}