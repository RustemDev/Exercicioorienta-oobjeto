using BoleanosECONDICIONAIS.Models;
using System;
using System.Collections.Generic;

namespace BoleanosECONDICIONAIS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo as industrias da Geraldo");
            //Aqui está criado um objeto- minhaEmpresa
            Empresa minhaEmpresa = new Empresa();
            //Aqui meu objeto - recebe a propriedade - Ativa q recebe o TRUE verdadeiro
            minhaEmpresa.Ativa = true;
            //Aqui a lista foi estanciada -- Sempre estanciar uma lista --
            minhaEmpresa.Funcionarios = new List<Pessoa>();
            //Aqui seis funcionarios foram criados individualmente

            //Aqui no cenario foram criados objetos dentro da lista - Pessoa, para guardar nas propriedades seu nome, idade e se está empregado 
            Pessoa func1 = new Pessoa();
            func1.NomePessoa = "Zezineo";
            func1.Idade = 45;
            func1.EstaEmpregado = false;
            //Aqui está chamando a propriedade- EstaEmpregado q está recebendo TRUE ou FALSE para indicar se ele está trabalhando ou não
            Pessoa func2 = new Pessoa();
            func2.NomePessoa = "Paulinho";
            func2.Idade = 30;
            func2.EstaEmpregado = false;

            Pessoa func3 = new Pessoa();
            func3.NomePessoa = "Geraldinho";
            func3.Idade = 28;
            func3.EstaEmpregado = false;

            Pessoa func4 = new Pessoa();
            func4.NomePessoa = "Luizinho";
            func4.Idade = 35;
            func4.EstaEmpregado = true;

            Pessoa func5 = new Pessoa();
            func5.NomePessoa = "Claudinho";
            func5.Idade = 20;
            func5.EstaEmpregado = true;

            Pessoa func6 = new Pessoa();
            func6.NomePessoa = "Pedrinho";
            func6.Idade = 18;
            func6.EstaEmpregado = false;

            //Aqui o IF verifica se o funcionario- Func1 está empregado ou não e se minha empresa está ativa ou não.
            //SE o funcionario1 está empregado for igual a Falso e minha empresa está ativa for igual a verdadeiro 
            if (func1.EstaEmpregado == false && minhaEmpresa.Ativa == true)
            {
                // Então meu objeto-minhaEmpresa que possui minha lista-Pessoa com a propriedade-Funcionarios estará adicionando o Func1 a minha lista de Funcionarios
                minhaEmpresa.Funcionarios.Add(func1);
                //Aqui o Func1 q agora está na lista Pessoa, foi colocado como TRUE pois ele virou verdadeiro e agora está contratado
                func1.EstaEmpregado = true;
            }
            

            if (func2.EstaEmpregado == false && minhaEmpresa.Ativa == true)
            {
                minhaEmpresa.Funcionarios.Add(func2);
                func2.EstaEmpregado = true;
            }

            if (func3.EstaEmpregado == false && minhaEmpresa.Ativa  == true)
            {
                minhaEmpresa.Funcionarios.Add(func3);
                func3.EstaEmpregado = true;
            }

            if (func4.EstaEmpregado== false && minhaEmpresa.Ativa == true)
            {
                minhaEmpresa.Funcionarios.Add(func4);
                func4.EstaEmpregado = true;

            }

            if (func5.EstaEmpregado == false && minhaEmpresa.Ativa == true)
            {
                minhaEmpresa.Funcionarios.Add(func5);
                func5.EstaEmpregado = true;
            }

            if (func6.EstaEmpregado==false && minhaEmpresa.Ativa == true)
            {
                minhaEmpresa.Funcionarios.Add(func6);
                func6.EstaEmpregado = true;
              
            }



            //Aqui foi estanciado o objeto MaquinaDeCafé e criado avariavel coffeemachine, para receber o método- PrepararCafé, onde está a formula q será apresentado ao usuario
            MaquinaDeCafe coffeemachine = new MaquinaDeCafe();
           
            //Sempre colocar - FN 11 para mostra o método, quando estiver debugando.

            //Aqui foi criada a variavel-retornoDaMaquina para receber o objeto coffeemachine juntamente com o método PrepararCafé usando o Func2 para execução
            string retornoDaMaquina = coffeemachine.PrepararCafe(func2);

            //Aqui será aprensentado a o usuario a frase que está dentro do método
            Console.WriteLine(retornoDaMaquina);

            //Aqui coffeemachinen chama o método- Ligar para informar q a maquina de café está ligada até que mude sua condição 
            coffeemachine.Ligar();
            
            //Aqui a Variavel- retornoDaMaquina recebe o método já com o funcionario2 para mostra para o usuario logo abaixo.
            retornoDaMaquina = coffeemachine.PrepararCafe(func2);

            Console.WriteLine(retornoDaMaquina);

            Console.ReadLine();
        }
    }
}
