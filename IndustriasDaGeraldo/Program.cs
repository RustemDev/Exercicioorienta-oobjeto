using System;
using System.Collections.Generic;
using IndustriasDaGeraldo.Models;

namespace IndustriasDaGeraldo
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "";
            int quantDeFunc = 0;
            string funcionarios = "";
            string opcaoCafe = "";


            Console.WriteLine("Bem vindo novo empresario das Industrias da Geraldo ");
            Console.WriteLine(" ");

            Empresa MinhaEmpresa = new Empresa();

            Console.WriteLine("Informe o nome da empresa");
            MinhaEmpresa.NomeDaEmpresa = Console.ReadLine();

            MinhaEmpresa.Ativa = true;
            Console.WriteLine("Sua empresa se encontra ativa ? ");
            Console.WriteLine(" ");
            Console.WriteLine("Digite s para sim ou n para não ");
            opcao = Console.ReadLine();

            if (opcao == "s")
            {
                MinhaEmpresa.Ativa = true;
                Console.WriteLine("Parabéns sua empresa está ativa ");
            }
            else if (opcao == "n")
            {
                MinhaEmpresa.Ativa = false;
                Console.WriteLine("Sua empresa não está ativa, vc precisa ativar sua empresa para entrar nas industrias da Geraldo");
            }

            while (opcao != "s" && opcao != "n")
            {
                Console.WriteLine("Opção invalida, por favor digite s ou n para não ");
                opcao = Console.ReadLine();
            }

            MinhaEmpresa.Funcionarios = new List<Pessoa>();
            Console.WriteLine("Digite quantos funcionarios você deseja cadastrar");
            quantDeFunc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A quntidade de funcionarios escolhida é " + quantDeFunc);

            List<Pessoa> nomeFunc = new List<Pessoa>();

            for (int i = 0; i < quantDeFunc; i++)
            {

                Pessoa Func = new Pessoa();

                Console.WriteLine("Por favor informe o nome do funcionario");
                Func.Nome = Console.ReadLine();

                Console.WriteLine("Agora informe a idade do funcionario");
                Func.Idade = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Agora informe se o seu funcionario está empregado ou não");
                Console.WriteLine("Digite s para está empregado ou n para não está empregado");
                opcao = (Console.ReadLine());

                if (opcao == "s")
                {
                    Func.EstaEmpregado = true;
                    Console.WriteLine("O funcionario está empregado");
                }
                else if (opcao == "n")
                {
                    Func.EstaEmpregado = false;
                    Console.WriteLine("O funcionario não está empregado");
                }
                while (opcao != "s" && opcao != "n")
                {
                    Console.WriteLine("Opção invalida, por favor digite s ou n para não ");
                    opcao = Console.ReadLine();
                }
                // colocar a regra q ele só pode entrar se ele estiver desempregado e se a empresa estiver ativa

                if (Func.EstaEmpregado == false && MinhaEmpresa.Ativa == true)
                {
                    MinhaEmpresa.Funcionarios.Add(Func);
                    Func.EstaEmpregado = true;
                }


            }
            int escolhaDoCafe = 0;
            


            Console.WriteLine("Agora escolha qual funcionario ira fazer o café ");
            
            


            //Aqui no FOR trago a variavel q criei para receber a lista Funcionarios e uso o (. Count) usado para a quantidade de funcionarios da Empresa
            for (int i = 0; i < MinhaEmpresa.Funcionarios.Count; i++)
            {
                //Aqui vai mostrar para o usuario 
                Console.WriteLine(i +" - " + MinhaEmpresa.Funcionarios[i].Nome);
           
            }

            escolhaDoCafe = Convert.ToInt32(Console.ReadLine());

            MaquinaDeCafe cafeDosFunc = new MaquinaDeCafe();



            //listar os funcs
            

            string quemFazCafe = cafeDosFunc.PrepararCafe(MinhaEmpresa.Funcionarios[escolhaDoCafe]);
            Console.WriteLine();

            cafeDosFunc.Ligar();

            quemFazCafe = cafeDosFunc.PrepararCafe(MinhaEmpresa.Funcionarios[escolhaDoCafe]);
            Console.WriteLine(quemFazCafe);

            //Aqui eu criei uma variavel e coloquei dentro um método auditoria e dentro entre parenteses(minhaEmpresa)
            string fazendoAudi = cafeDosFunc.Auditoria(MinhaEmpresa);
            Console.WriteLine("Sua empresa continua ativa ? ");
            //Aqui minha variavel chama o método Ativar que recebe o TRUE e q agora é verdadeiro
            MinhaEmpresa.Ativa = true;
            
            Console.WriteLine(" ");
            Console.WriteLine("Digite s para sim ou n para não ");
            opcao = Console.ReadLine();

            if (opcao == "s")
            {
                MinhaEmpresa.Ativa= true;
                
                Console.WriteLine(fazendoAudi); 
            }
            else if (opcao == "n")
            {
                MinhaEmpresa.Ativa = false;
                
                Console.WriteLine(fazendoAudi);
            }

            while (opcao != "s" && opcao != "n")
            {
                Console.WriteLine("Opção invalida, por favor digite s ou n para não ");
                opcao = Console.ReadLine();
            }

            
           

            //Aqui o FOR fará a contagem de cada funcionario e colocara na tela junto com suas posições e nomes
            for (int i = 0; i < MinhaEmpresa.Funcionarios.Count; i++)
            {
                //Aqui vai mostrar para o usuario a posição- i, com espaço, concatenado com a lista de funcionarios e seus nomes
                Console.WriteLine(i + " - " + MinhaEmpresa.Funcionarios[i].Nome);

            }


            Console.WriteLine("Escolha qual funcionario vc vai demitir");
            escolhaDoCafe = Convert.ToInt32(Console.ReadLine());
            //Aqui foi estanciado o objeto Empresa e criado avariavel mandandoEmbora, para receber o método- Demitir,  q será apresentado ao usuario
            Empresa mandandoEmbora = new Empresa();
            //
            string quemSai = mandandoEmbora.Demitir(MinhaEmpresa.Funcionarios[escolhaDoCafe]);
            Console.WriteLine(quemSai);

            quemSai = mandandoEmbora.Demitir(MinhaEmpresa.Funcionarios[escolhaDoCafe]);
            Console.WriteLine(quemSai);



            Console.WriteLine("Nos arrependemos, informe qual dos funcionarios será recontratado");

            for (int i = 0; i < MinhaEmpresa.Funcionarios.Count; i++)
            {
                if (MinhaEmpresa.Funcionarios[i].EstaEmpregado == false && MinhaEmpresa.Funcionarios[i].Idade > 18)
                {
                    Console.WriteLine("nome do desempregado " + MinhaEmpresa.Funcionarios[i].Nome + " posição: " + i);
                }
            }


            Console.ReadLine();
        }
    }
}
