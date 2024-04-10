namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrecionTablaGDescuento : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.GrupoDescuentoes", "Porcentaje", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.GrupoDescuentoes", "Porcentaje", c => c.Boolean(nullable: false));
        }
    }
}
