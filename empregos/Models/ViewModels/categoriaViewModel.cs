using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace empregos.Models.ViewModels
{
    [Serializable]
    public class categoriaViewModel
    {
        public int id { get; set; }

        public string descricao { get; set; }

        public string titulo { get; set; }   

        public List<anuncio> anunlist { get; set; }
        public List<AnuncioViewModel> anunViewModellist { get; set; }
    }
}