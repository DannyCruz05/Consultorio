namespace CapaDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CambioTablas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Citas", "FechaCreacion", c => c.DateTime(nullable: false));
            AddColumn("dbo.Citas", "FechaModificacion", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Citas", "FechaModificacion");
            DropColumn("dbo.Citas", "FechaCreacion");
        }
    }
}
