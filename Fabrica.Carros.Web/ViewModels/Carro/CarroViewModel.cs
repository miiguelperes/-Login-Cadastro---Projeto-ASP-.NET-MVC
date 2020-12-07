using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fabrica.Carros.Web.ViewModels.Carro
{
    public class CarroViewModel
    {
        [Required(ErrorMessage = "Id Obrigatório")]
        public long IdCarro { get; set; }

        [Required(ErrorMessage = "Nome da Carro Obrigatório")]
        [Display(Name = "Nome da Carro")]
        public string NomeCarro { get; set; }

        [Required(ErrorMessage = "Cor da Carro Obrigatório")]
        [Display(Name = "Cor da Carro")]
        public string Cor { get; set; }

        [Required(ErrorMessage = "Tamanho da Carro Obrigatório")]
        [Display(Name = "Tamanho da Carro")]
        public string Tamanho { get; set; }

        [Required(ErrorMessage = "Selecione o Tipo de Fabricante")]
        [Display(Name = "Tipo de Fabricante")]
        public int idFabricante { get; set; }

        [Required(ErrorMessage = "Coloque o Ano de Fabricação")]
        [Display(Name = "Ano de Fabricação")]
        public int Ano { get; set; }
    }
}