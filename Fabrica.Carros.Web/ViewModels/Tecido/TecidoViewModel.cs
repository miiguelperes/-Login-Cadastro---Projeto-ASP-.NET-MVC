using Fabrica.Carros.Web.Anotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fabrica.Carros.Web.ViewModels.Fabricante
{
    public class FabricanteViewModel
    {
        [Required(ErrorMessage ="O Id é Obrigatório")]
        public int Id { get; set; }

        [Required(ErrorMessage = "O Nome do Tipo é Obrigatório")]
        [MaxLength(100, ErrorMessage =("O nome do tipo deve ter no máximo 100 caracteres"))]
        [Display(Name = "Nome do Tipo do Fabricante")]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "A Composição é Obrigatório")]
        [MaxLength(100, ErrorMessage = ("A composição do Fabricante deve ter no máximo 100 caracteres"))]
        [Display(Name = "Composição do Fabricante")]
        public string Composicao { get; set; }

        [Required(ErrorMessage = "A Caracteristica é Obrigatório")]
        [MaxLength(100, ErrorMessage = ("A Caracteristica do Fabricante deve ter no máximo 100 caracteres"))]
        [Display(Name = "Característica do Fabricante")]
        public string Caracteristica { get; set; }

        [Required(ErrorMessage = "O Nome do Fornecedor é Obrigatório")]
        [MaxLength(100, ErrorMessage = ("O Nome do Fornecedor deve ter no máximo 100 caracteres"))]
        [Display(Name = "Nome do Fornecedor")]
        public string Fornecedor { get; set; }

        [Required(ErrorMessage = "O Email do Fornecedor é Obrigatório")]
        [MaxLength(100, ErrorMessage = ("O Email do Fornecedor deve ter no máximo 100 caracteres"))]
        [Display(Name = "Email do Fornecedor")]
        [Email(ErrorMessage = "O dominio do E-mail deve ser @unipam.edu.br")]
        public string Email { get; set; }
    }
}