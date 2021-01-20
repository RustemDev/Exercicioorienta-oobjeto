using System;
using System.Collections.Generic;
using System.Text;

namespace BoleanosECONDICIONAIS.Models
{
    public class MaquinaDeCafe
    {
        public bool EstaLigada { get; set; }

        public string Ligar()
        {
            //Aqui entra a regra de negocio q permite ligar a maquina se ela estiver desligada

            if (EstaLigada == true)
            {
                return "A maquina ja está ligada";
            }
            else
            {
                EstaLigada = true;
                return "a mquina foi ligada, pode usar :)";
            }



        }

        public string PrepararCafe(Pessoa funcionario)
        {
            //Aqui se a maquina estiver ligada vai retornar q esta preparando o café se não vai pedir para ligar a maquina antes de preparar o café

            if (EstaLigada)
            {
                return "A maquina está preparando o café " + funcionario.NomePessoa;
            }
            else
            {
                return "não foi possivel fazer o seu cafe";
            }

        }
    }
}
