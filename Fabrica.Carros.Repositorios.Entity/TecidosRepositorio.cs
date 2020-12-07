using Fabrica.Carros.Dados.Entity.Context;
using Fabrica.Carros.Dominio;
using Fabrica.Repositorios.Comum.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Fabrica.Carros.Repositorios.Entity
{
    public class FabricantesRepositorio : RepositorioGenericoEntity<Fabricante, int>
    {
        public FabricantesRepositorio(CarroDbContext contexto) : base(contexto)
        {

        }

        public override List<Fabricante> Selecionar()
        {
            return _contexto.Set<Fabricante>().Include(p => p.Carros).ToList();
        }

        public override Fabricante SelecionarPorId(int id)
        {
            return _contexto.Set<Fabricante>().Include(p => p.Carros)
                            .SingleOrDefault(t => t.Id == id);
        }
    }
}
