namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrecionTipoDeEntradaDeDatos : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pedidoes", "Estado", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pedidoes", "Estado", c => c.Int(nullable: false));
        }
    }
}
