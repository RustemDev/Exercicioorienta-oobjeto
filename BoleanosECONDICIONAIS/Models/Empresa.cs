using System;
using System.Collections.Generic;
using System.Text;

namespace BoleanosECONDICIONAIS.Models
{
   public class Empresa
    {
        public string NomeDaEmpresa { get; set; }
        public List<Pessoa> Funcionarios { get; set; }

        public bool Ativa { get; set; }

    }
}
