﻿namespace CapaDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionDeTablaMedicos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Medicos",
                c => new
                    {
                        MedicoId = c.Int(nullable: false, identity: true),
                        Nombres = c.String(nullable: false, maxLength: 120),
                        Apellidos = c.String(nullable: false, maxLength: 120),
                        FechaIngreso = c.DateTime(nullable: false),
                        Estado = c.Boolean(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                        FechaModificacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MedicoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Medicos");
        }
    }
}
