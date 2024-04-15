using CapaDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CapaDatos.BaseDeDatos
{
    public class ConsultorioContext : DbContext
    {

        public ConsultorioContext() : base("Consultorio")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<PacientesModel> Clientes { get; set; }
        public DbSet<MedicosModel> Medicos { get; set; }
        public DbSet<CitasModel> Citas { get; set; }
    }
}
