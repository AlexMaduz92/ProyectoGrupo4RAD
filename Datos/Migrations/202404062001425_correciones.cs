namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class correciones : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "Codigo", c => c.String());
            AddColumn("dbo.GrupoDescuentoes", "Porcentaje", c => c.Boolean(nullable: false));
            AddColumn("dbo.FacturaDetalles", "FechaCreacion", c => c.DateTime(nullable: false));
            AddColumn("dbo.FacturaDetalles", "SubTotal", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.PedidoDetalles", "FechaCreacion", c => c.DateTime(nullable: false));
            DropColumn("dbo.Clientes", "TipoDocumento");
            DropColumn("dbo.Clientes", "NumeroDocumento");
            DropColumn("dbo.Clientes", "Direccion");
            DropColumn("dbo.Clientes", "Telefono");
            DropColumn("dbo.Clientes", "Email");
            DropColumn("dbo.PedidoDetalles", "Cantidad");
            DropColumn("dbo.Productoes", "Codigo");
            DropColumn("dbo.Productoes", "Descripcion");
            DropColumn("dbo.Productoes", "PrecioVenta");
            DropColumn("dbo.Productoes", "Stock");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Productoes", "Stock", c => c.Int(nullable: false));
            AddColumn("dbo.Productoes", "PrecioVenta", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Productoes", "Descripcion", c => c.String());
            AddColumn("dbo.Productoes", "Codigo", c => c.String());
            AddColumn("dbo.PedidoDetalles", "Cantidad", c => c.Int(nullable: false));
            AddColumn("dbo.Clientes", "Email", c => c.String());
            AddColumn("dbo.Clientes", "Telefono", c => c.String());
            AddColumn("dbo.Clientes", "Direccion", c => c.String());
            AddColumn("dbo.Clientes", "NumeroDocumento", c => c.String());
            AddColumn("dbo.Clientes", "TipoDocumento", c => c.String());
            DropColumn("dbo.PedidoDetalles", "FechaCreacion");
            DropColumn("dbo.FacturaDetalles", "SubTotal");
            DropColumn("dbo.FacturaDetalles", "FechaCreacion");
            DropColumn("dbo.GrupoDescuentoes", "Porcentaje");
            DropColumn("dbo.Clientes", "Codigo");
        }
    }
}
