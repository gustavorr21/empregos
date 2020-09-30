using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace empregos.Models.ViewModels
{
    [Serializable]
    public class AnuncioViewModel
    {
        public int id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "A descrição é obrigatório.")]
        public string descricao { get; set; }

        [Display(Name = "Preço")]
        [Required(ErrorMessage = "O preço é obrigatório", AllowEmptyStrings = false)]
        public decimal preco { get; set; }

        [Display(Name = "Medida")]
        public decimal medida { get; set; }

        public virtual usuarioViewModel usuario { get; set; }
        public List<usuarioViewModel> usu { get; set; }
        public string nomeUsuario { get; set; }

        public int idUsuario { get; set; }

        [Display(Name = "Categoria")]
        [Required(ErrorMessage = "A categoria é obrigatório", AllowEmptyStrings = false)]
        public virtual categoria cat { get; set; }
        public List<categoriaViewModel> categoria { get; set; }
        public int idcategoria { get; set; }
        //public blob foto1 { get; set; }
        //foto2{ get; set; }

        public string foto1 { get; set; }

        public string foto2 { get; set; }
    }
}