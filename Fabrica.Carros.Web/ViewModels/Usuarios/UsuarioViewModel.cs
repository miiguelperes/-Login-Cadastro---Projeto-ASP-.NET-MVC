using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fabrica.Carros.Web.ViewModels.Usuarios
{
    public class UsuarioViewModel
    {
        [Required(ErrorMessage = "O E-mail é Obrigatorio.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A senha é Obrigatória.")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}