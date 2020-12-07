using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fabrica.Carros.Web.Identity
{
    public class CarroIdentityDbContext : IdentityDbContext<IdentityUser>
    {
        public CarroIdentityDbContext()
            : base("CarroDbContext")
        {
            
        }
        
    }
}