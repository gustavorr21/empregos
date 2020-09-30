using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using empregos.Models.ViewModels;
using empregos.Models;

namespace empregos.Mappers
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }
        protected override void Configure()
        {
            this.CreateMap<AnuncioViewModel, anuncio>();
            this.CreateMap<usuarioViewModel, usuario>();
            this.CreateMap<categoriaViewModel, categoria>();
        }
        //public ViewModelToDomainMappingProfile()
        //{
        //    this.CreateMap<AnuncioViewModel,anuncio>();
        //}
    }
}