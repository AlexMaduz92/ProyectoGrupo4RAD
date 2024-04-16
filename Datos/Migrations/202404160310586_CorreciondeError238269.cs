namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorreciondeError238269 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Clientes", "CondicionPago_CondicionPagoId", "dbo.CondiccionPagoes");
            DropForeignKey("dbo.Clientes", "GrupoDescuento_GrupoDescuentoId", "dbo.GrupoDescuentoes");
            DropIndex("dbo.Clientes", new[] { "CondicionPago_CondicionPagoId" });
            DropIndex("dbo.Clientes", new[] { "GrupoDescuento_GrupoDescuentoId" });
            RenameColumn(table: "dbo.Clientes", name: "CondicionPago_CondicionPagoId", newName: "CondicionPagoId");
            RenameColumn(table: "dbo.Clientes", name: "GrupoDescuento_GrupoDescuentoId", newName: "GrupoDescuentoId");
            AlterColumn("dbo.Clientes", "CondicionPagoId", c => c.Int(nullable: false));
            AlterColumn("dbo.Clientes", "GrupoDescuentoId", c => c.Int(nullable: false));
            CreateIndex("dbo.Clientes", "GrupoDescuentoId");
            CreateIndex("dbo.Clientes", "CondicionPagoId");
            AddForeignKey("dbo.Clientes", "CondicionPagoId", "dbo.CondiccionPagoes", "CondicionPagoId", cascadeDelete: true);
            AddForeignKey("dbo.Clientes", "GrupoDescuentoId", "dbo.GrupoDescuentoes", "GrupoDescuentoId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clientes", "GrupoDescuentoId", "dbo.GrupoDescuentoes");
            DropForeignKey("dbo.Clientes", "CondicionPagoId", "dbo.CondiccionPagoes");
            DropIndex("dbo.Clientes", new[] { "CondicionPagoId" });
            DropIndex("dbo.Clientes", new[] { "GrupoDescuentoId" });
            AlterColumn("dbo.Clientes", "GrupoDescuentoId", c => c.Int());
            AlterColumn("dbo.Clientes", "CondicionPagoId", c => c.Int());
            RenameColumn(table: "dbo.Clientes", name: "GrupoDescuentoId", newName: "GrupoDescuento_GrupoDescuentoId");
            RenameColumn(table: "dbo.Clientes", name: "CondicionPagoId", newName: "CondicionPago_CondicionPagoId");
            CreateIndex("dbo.Clientes", "GrupoDescuento_GrupoDescuentoId");
            CreateIndex("dbo.Clientes", "CondicionPago_CondicionPagoId");
            AddForeignKey("dbo.Clientes", "GrupoDescuento_GrupoDescuentoId", "dbo.GrupoDescuentoes", "GrupoDescuentoId");
            AddForeignKey("dbo.Clientes", "CondicionPago_CondicionPagoId", "dbo.CondiccionPagoes", "CondicionPagoId");
        }
    }
}
