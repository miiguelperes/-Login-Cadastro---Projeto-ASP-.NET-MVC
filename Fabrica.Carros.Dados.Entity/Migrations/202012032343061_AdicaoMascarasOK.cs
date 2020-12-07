namespace Fabrica.Carros.Dados.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicaoCarrosOK : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carro",
                c => new
                    {
                        IdCarro = c.Long(nullable: false, identity: true),
                        NomeCarro = c.String(nullable: false, maxLength: 100),
                        Cor = c.String(nullable: false, maxLength: 50),
                        Tamanho = c.String(nullable: false, maxLength: 50),
                        idFabricante = c.Int(nullable: false),
                        Ano = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdCarro)
                .ForeignKey("dbo.Fabricante", t => t.idFabricante, cascadeDelete: true)
                .Index(t => t.idFabricante);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Carro", "idFabricante", "dbo.Fabricante");
            DropIndex("dbo.Carro", new[] { "idFabricante" });
            DropTable("dbo.Carro");
        }
    }
}
