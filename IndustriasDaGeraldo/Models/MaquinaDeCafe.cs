using System;
using System.Collections.Generic;
using System.Text;

namespace IndustriasDaGeraldo.Models
{
    public class MaquinaDeCafe
    {
        public bool EstaLigada { get; set; }

        public string Ligar()
        {
            if (EstaLigada == true)
            {
                return "A maquina está ligada";

            }
            else
                EstaLigada = true;
            return "A maquina foi ligada, pode usar";
        }
        public string PrepararCafe(Pessoa funcio)
        {
            //Aqui se a maquina estiver ligada vai retornar q esta preparando o café se não vai pedir para ligar a maquina antes de preparar o café
            if (EstaLigada)
            {                                              //Aqui vai a lista - Funcionario.Nome pessoa, para indicar quem vai ligar a maquina
                return "A maquina está preparando o café para o funcionario " + funcio.Nome;
            }
            else
            {
                return "Não foi possivel fazer o seu café";
            }

           
        }
        public string Auditoria(Empresa Emp)
        {
            if (Emp.Ativa == true)
            {
                return "Tudo OK ";
            }
            else
            {
                return "Você não pode usar essa maquina";
            }
        }
    }
}
