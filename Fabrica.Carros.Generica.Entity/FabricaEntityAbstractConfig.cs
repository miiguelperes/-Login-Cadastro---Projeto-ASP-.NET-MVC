using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica.Carros.Generica.Entity
{
    public abstract class FabricaEntityAbstractConfig<TEntidade> : EntityTypeConfiguration<TEntidade>
        where TEntidade : class
    {
        public FabricaEntityAbstractConfig()
        {
            ConfigurarNomeTabela();
            ConfigurarCamposTabela();
            ConfigurarChavePrimaria();
            ConfigurarChaveEstrangeira();
        }

        protected abstract void ConfigurarChaveEstrangeira();

        protected abstract void ConfigurarChavePrimaria();

        protected abstract void ConfigurarCamposTabela();

        protected abstract void ConfigurarNomeTabela();
    }
}
