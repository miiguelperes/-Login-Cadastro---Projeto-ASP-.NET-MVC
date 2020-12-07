using Fabrica.Carros.Dominio;
using Fabrica.Carros.Generica.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica.Carros.Dados.Entity.TypeConfiguration
{
    class FabricanteTypeConfiguration : FabricaEntityAbstractConfig<Fabricante>
    {
        protected override void ConfigurarCamposTabela()
        {
            Property(p => p.Id)
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .HasColumnName("Id");

            Property(p => p.Tipo)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("Tipo");

            Property(p => p.Composicao)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("Composicao");

            Property(p => p.Composicao)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("Composicao");

            Property(p => p.Caracteristica)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("Caracteristica");

            Property(p => p.Fornecedor)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("Fornecedor");

            Property(p => p.Email)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("Email");                     
            
            
        }

        protected override void ConfigurarChaveEstrangeira()
        {
            
        }

        protected override void ConfigurarChavePrimaria()
        {
            HasKey(pk => pk.Id);
        }

        protected override void ConfigurarNomeTabela()
        {
            ToTable("Fabricante");
        }
    }
}
