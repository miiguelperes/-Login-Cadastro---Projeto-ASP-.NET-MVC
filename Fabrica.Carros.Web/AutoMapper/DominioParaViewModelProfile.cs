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
    public class DominioParaViewModelProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Fabricante, FabricanteIndexViewModel>()
                .ForMember(p => p.Tipo, opt =>
                {
                    opt.MapFrom(src =>
                    string.Format("{0}, {1}", src.Tipo, src.Fornecedor.ToString())
                    );
                });
            Mapper.CreateMap<Fabricante, FabricanteIndexViewModel>();

            Mapper.CreateMap<Carro, CarroIndexViewModels>()
                .ForMember(p => p.NomeFabricante, opt =>
                {
                    opt.MapFrom(src =>
                        src.Fabricante.Tipo
                        );
                });

            Mapper.CreateMap<Carro, CarroViewModel>();
        }
    }
}