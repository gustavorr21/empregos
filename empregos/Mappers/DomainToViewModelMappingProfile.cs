using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using empregos.Models.ViewModels;
using empregos.Models;

namespace empregos.Mappers
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            this.CreateMap<anuncio, AnuncioViewModel>().ForMember(c=>c.categoria, categoria=>categoria.Ignore())
                .ForMember(c => c.cat, cat => cat.Ignore());
            this.CreateMap<usuario, usuarioViewModel>();
            this.CreateMap<categoria, categoriaViewModel>();
        }
    }
}