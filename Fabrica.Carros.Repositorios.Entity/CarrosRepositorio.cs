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
    public class CarrosRepositorio : RepositorioGenericoEntity<Carro, long>
    {
        public CarrosRepositorio(CarroDbContext contexto) : base(contexto)
        {

        }

        public override List<Carro> Selecionar()
        {
            return _contexto.Set<Carro>().Include(p => p.Fabricante).ToList();
        }

        public override Carro SelecionarPorId(long id)
        {
            return _contexto.Set<Carro>().Include(p => p.Fabricante)
                .SingleOrDefault(m => m.IdCarro == id);
        }
    }
}
