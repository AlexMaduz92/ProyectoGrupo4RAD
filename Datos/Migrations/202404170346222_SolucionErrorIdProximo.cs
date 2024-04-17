namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SolucionErrorIdProximo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FacturaDetalles", "Estado", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.FacturaDetalles", "Estado");
        }
    }
}
