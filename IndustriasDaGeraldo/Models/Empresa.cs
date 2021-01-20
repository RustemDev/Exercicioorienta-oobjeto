using System;
using System.Collections.Generic;
using System.Text;

namespace IndustriasDaGeraldo.Models
{
    public class Empresa
    {
        public string NomeDaEmpresa { get; set; }
        public List <Pessoa> Funcionarios { get; set; }

        public bool Ativa { get; set; }

       public string Demitir (Pessoa FuncMal)
        {
            if (FuncMal.EstaEmpregado == true)
            {
                FuncMal.EstaEmpregado = false;
                    return "O funcionario foi desligado da empresa"; 

            }
            else
            {
                return "Esse funcionario não pertence a essa empresa";
            }
            

            
        }
        public string Admitir (Pessoa FuncAd)
        {
            if (FuncAd.EstaEmpregado == false)
            {
                FuncAd.EstaEmpregado = true;
                return "O funcionario foi reademitido";
            }
            else
            {
                return "Esse funcionario já existe";
            }
        }
    }

    
}
