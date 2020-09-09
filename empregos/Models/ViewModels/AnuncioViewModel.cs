using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace empregos.Models.ViewModels
{
    public class AnuncioViewModel
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public decimal preco { get; set; }
        public decimal medida { get; set; }
        public virtual usuarioViewModel usuario { get; set; }
        public int idUsuario { get; set; }
        public List<categoriaViewModel> categoria { get; set; }
        public int idcategoria { get; set; }
        //public blob foto1 { get; set; }
        //foto2{ get; set; }
}
}