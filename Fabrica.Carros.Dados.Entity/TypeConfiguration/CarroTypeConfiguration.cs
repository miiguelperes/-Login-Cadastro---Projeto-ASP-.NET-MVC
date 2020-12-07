using Fabrica.Carros.Dominio;
using Fabrica.Carros.Generica.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Fabrica.Carros.Dados.Entity.TypeConfiguration
{
    class CarroTypeConfiguration : FabricaEntityAbstractConfig<Carro>
    {
        protected override void ConfigurarCamposTabela()
        {
            Property(p => p.IdCarro)
                .HasColumnName("IdCarro")
                .HasDatabaseGeneratedOption(System.ComponentModel
                                            .DataAnnotations.Schema
                                            .DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(p => p.NomeCarro)
                .HasColumnName("NomeCarro")
                .HasMaxLength(100)
                .IsRequired();

            Property(p => p.Cor)
                .HasColumnName("Cor")
                .HasMaxLength(50)
                .IsRequired();

            Property(p => p.Tamanho)
                .HasColumnName("Tamanho")
                .HasMaxLength(50)
                .IsRequired();

            Property(p => p.idFabricante)
                .HasColumnName("idFabricante")
                .IsRequired();

            Property(p => p.Ano)
                .IsRequired()
                .HasColumnName("Ano");

        }

        protected override void ConfigurarChaveEstrangeira()
        {
            HasRequired(p => p.Fabricante)
                .WithMany(p => p.Carros)
                .HasForeignKey(fk => fk.idFabricante);
        }

        protected override void ConfigurarChavePrimaria()
        {
            HasKey(pk => pk.IdCarro);
        }

        protected override void ConfigurarNomeTabela()
        {
            ToTable("Carro");
        }
    }
}
