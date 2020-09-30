using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace empregos.Models.ViewModels
{
    [Serializable]
    public class usuarioViewModel
    {
        public int id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O nome completo é obrigatório.")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage =
            "Números e caracteres especiais não são permitidos no nome.")]
        public string nome { get; set; }

        [Display(Name = "Email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido...")]
        public string email { get; set; }

        [Display(Name = "CPF")]
        [Required(ErrorMessage = "O nome do usuário é obrigatório", AllowEmptyStrings = false)]
        public int cpf { get; set; }

        [Display(Name = "Tel")]
        [Required(ErrorMessage = "O nome do usuário é obrigatório", AllowEmptyStrings = false)]
        public string telefone { get; set; }

        [Display(Name = "Tel 2")]
        public string telefone2 { get; set; }

        [Display(Name = "CEP")]
        [Required(ErrorMessage = "O nome do cep é obrigatório", AllowEmptyStrings = false)]
        public int cep { get; set; }

        [Display(Name = "Rua")]
        [Required(ErrorMessage = "O nome da rua é obrigatório", AllowEmptyStrings = false)]
        public string rua { get; set; }

        [Display(Name = "Bairro")]
        [Required(ErrorMessage = "O nome do bairro é obrigatório", AllowEmptyStrings = false)]
        public string bairro { get; set; }

        [Display(Name = "Cidade")]
        [Required(ErrorMessage = "O nome da cidade é obrigatório", AllowEmptyStrings = false)]
        public string cidade { get; set; }

        [Display(Name = "Estado")]
        [Required(ErrorMessage = "O nome do estado é obrigatório", AllowEmptyStrings = false)]
        public string estado { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(10, MinimumLength = 4)]
        [Display(Name = "Senha")]
        public string senha { get; set; }

        public string perfil { get; set; }

        [Display(Name = "Data Nascimento")]
        [DisplayFormat(DataFormatString = "mm/dd/yyyy")]
        [Required]
        public DateTime dataNascimento { get; set; }

        public List<AnuncioViewModel> anuncio { get; set; }

    }
}