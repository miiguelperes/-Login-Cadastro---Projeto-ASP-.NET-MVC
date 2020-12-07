using Fabrica.Carros.Dados.Entity.TypeConfiguration;
using Fabrica.Carros.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica.Carros.Dados.Entity.Context
{
    public class CarroDbContext : DbContext
    {
        public DbSet<Fabricante> Fabricantes { get; set; }
        public DbSet<Carro> Carros { get; set; }

        public CarroDbContext()
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new FabricanteTypeConfiguration());
            modelBuilder.Configurations.Add(new CarroTypeConfiguration());
        }
    }
}
