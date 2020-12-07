namespace Fabrica.Carros.Dados.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigracaoInicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fabricante",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tipo = c.String(nullable: false, maxLength: 100),
                        Composicao = c.String(nullable: false, maxLength: 100),
                        Caracteristica = c.String(nullable: false, maxLength: 100),
                        Fornecedor = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Fabricante");
        }
    }
}
