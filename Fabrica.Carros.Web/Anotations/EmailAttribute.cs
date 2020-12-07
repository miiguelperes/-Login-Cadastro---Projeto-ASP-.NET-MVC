using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fabrica.Carros.Web.Anotations
{
    public class EmailAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return value.ToString().EndsWith("@unipam.edu.br");
        }
    }
}