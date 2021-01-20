using System;
using System.Collections.Generic;
using System.Text;

namespace UsandoBooleanos.Models
{
    public class Cliente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int Senha { get; set; }
        public double Saldo { get; set; }
        public bool MaiorDeIdade { get; set; }
        public bool ClienteVip { get; set; }

        public void Sacar(double valor)
        {
            if (ClienteVip)
            {
                Saldo = (Saldo - valor) + 20;
            }
            else
            {
                Saldo = Saldo - valor;
            }

        }
    }




}


