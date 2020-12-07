using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fabrica.Carros.Web.ViewModels.Fabricante
{
    public class FabricanteIndexViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Nome do Tipo do Fabricante")]
        public string Tipo { get; set; }

        [Display(Name = "Composição do Fabricante")]
        public string Composicao { get; set; }

        [Display(Name = "Característica do Fabricante")]
        public string Caracteristica { get; set; }

        [Display(Name = "Nome do Fornecedor")]
        public string Fornecedor { get; set; }

        [Display(Name = "Email do Fornecedor")]
        public string Email { get; set; }
    }
}