namespace CapaDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionTablaDeCitas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Citas",
                c => new
                    {
                        CitaId = c.Int(nullable: false, identity: true),
                        PacienteId = c.Int(nullable: false),
                        MedicoId = c.Int(nullable: false),
                        Nombres = c.String(nullable: false, maxLength: 120),
                        Apellidos = c.String(nullable: false, maxLength: 120),
                        FechaCita = c.DateTime(nullable: false),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CitaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Citas");
        }
    }
}
