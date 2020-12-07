using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fabrica.Carros.Web.ViewModels.Carro
{
    public class CarroIndexViewModels
    {
        public long IdCarro { get; set; }

        [Display(Name = "Nome da Carro")]
        public string NomeCarro { get; set; }

        [Display(Name = "Cor da Carro")]
        public string Cor { get; set; }

        [Display(Name = "Tamanho da Carro")]
        public string Tamanho { get; set; }

        [Display(Name = "Nome do Fabricante")]
        public string NomeFabricante { get; set; }

        [Display(Name = "Ano de Fabricação")]
        public int Ano { get; set; }
    }
}