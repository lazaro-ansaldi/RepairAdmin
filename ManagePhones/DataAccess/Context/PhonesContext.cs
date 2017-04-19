using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Entities.Entidades;

namespace DataAccess.Context
{
    public class PhonesContext : DbContext
    {
        private const string CONTEXTNAME = "DefaultConnection";

        public PhonesContext() : base(CONTEXTNAME) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Modelo> Modelos { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<RepairOrder> RepairOrders { get; set; }
        public DbSet<Marca> Marcas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
