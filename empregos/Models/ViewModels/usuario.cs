using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace empregos.Models.ViewModels
{
    public class usuario
    {
        public int id { get; set; }

        public string nome { get; set; }

        public string email { get; set; }

        public int cpf { get; set; }

        public string telefone { get; set; }

        public string telefone2 { get; set; }

        public int cep { get; set; }

        public string rua { get; set; }

        public string bairro { get; set; }

        public string cidade { get; set; }

        public string estado { get; set; }

        public string senha { get; set; }

        public string perfil { get; set; }

        public DateTime dataNascimento { get; set; }

    }
}