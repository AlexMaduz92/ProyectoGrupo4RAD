﻿namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CambioTipoEstadoPedidos : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pedidoes", "Estado", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pedidoes", "Estado", c => c.Byte(nullable: false));
        }
    }
}
