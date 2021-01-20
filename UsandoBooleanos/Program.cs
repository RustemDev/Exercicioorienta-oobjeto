using System;
using UsandoBooleanos.Models;

namespace UsandoBooleanos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aqui foi criado uma variavel para receber os numeros e armazenar em - valorSacar
            double valorSacar = 0;

            //Aqui foi criado um objeto para ser trabalhado
            Cliente cli = new Cliente();

            //Aqui está o primeiro texto apresentado na tela para o usuario
            Console.WriteLine(" Bem vindo ao Banco do Geraldo");

            //Aqui o objeto cli usa a propriedade nome para armazenar o nome do usuario
            Console.WriteLine("Informe seu nome");
            cli.Nome = Console.ReadLine();

            Console.WriteLine("Informe sua senha");
            cli.Senha = Convert.ToInt32(Console.ReadLine());

            //Aqui o objeto cli usa a propriedade Idade para armazenar a idade do usuario
            Console.WriteLine("Informe sua idade");
            cli.Idade = Convert.ToInt32(Console.ReadLine());

            //Aqui SE a idade informada for maior q 21 então é verdadeiro que o cli é Maior de  idade
            if (cli.Idade > 21)
            {
                cli.MaiorDeIdade = true;
            }

            //Aqui o clinte informa o seu saldo e é convertido em ToDouble que trabalha com numeros quebrados
            Console.WriteLine("Informe seu saldo");
            cli.Saldo = Convert.ToDouble(Console.ReadLine());

            //Aqui SE o cliente for maior de idade e o seu saldo for maior q 500 então é verdadeiro q ele é ClienteVip
            if (cli.MaiorDeIdade && cli.Saldo > 500)
            {
                cli.ClienteVip = true;
            }

            //Aqui caso o cliente for maior de idade OU sua senha for igual a 1789 então é verdadeiro q é ClienteVip
            else if (cli.MaiorDeIdade || cli.Senha == 1789)
            {
                cli.ClienteVip = true;
            }
            else
            {
                cli.ClienteVip = false;
            }

            //Aqui o texto é concatenado para saida do saldo, expondo na tela para o cliente o valor de seu saldo
            Console.WriteLine("Seu saldo atual é de " + cli.Saldo);

            //Aqui o usuario informa o valor q deseja sacar q é convertido com o ToDouble e colocado dentro da variavel - valorSacar
            Console.WriteLine("Informe quanto deseja sacar");
            valorSacar = Convert.ToDouble(Console.ReadLine());

            //Aqui o sacar tem um método ClienteVip que dentro está a formula - saldo - valor + 20, tornando assim o cliente Vip
            cli.Sacar(valorSacar);

            //Aqui a frase final é concatenada com o salado restante do cliente e informado na tela
            Console.WriteLine("Seu novo saldo é de " + cli.Saldo);

            Console.ReadLine();
        }
    }
}
