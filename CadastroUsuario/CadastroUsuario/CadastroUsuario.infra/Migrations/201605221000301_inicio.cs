namespace CadastroUsuario.infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicio : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 100),
                        Senha = c.String(nullable: false, maxLength: 8),
                        Telefone = c.String(nullable: false, maxLength: 9),
                        DDD = c.String(nullable: false, maxLength: 3),
                        Data_Criacao = c.DateTime(nullable: false),
                        Data_Atualizacao = c.DateTime(nullable: false),
                        Ultimo_Login = c.DateTime(nullable: false),
                        Token = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuario");
        }
    }
}
