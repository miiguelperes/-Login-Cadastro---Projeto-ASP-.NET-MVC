using AutoMapper;
using Fabrica.Carros.Dominio;
using Fabrica.Carros.Web.ViewModels.Carro;
using Fabrica.Carros.Web.ViewModels.Fabricante;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fabrica.Carros.Web.AutoMapper
{
    public class ViewModelParaDominioProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<FabricanteViewModel, Fabricante>();
            Mapper.CreateMap<CarroViewModel, Carro>();
        }
    }
}