using System;

namespace questão_2___semanas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, seja bem vindo(a), este é um sistema que vai calcular quantos anos você tem.");
            Console.WriteLine("");

            Console.WriteLine("Qual é o ano de nascimento?");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Aí sim!");
            Console.WriteLine("");

            Console.WriteLine("Em que ano você está?");
            int ano = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Boa!");
            Console.WriteLine("");

            int idadepessoa = (ano - idade);
            int semanas = (idadepessoa * 52);

            Console.WriteLine("Você gostaria de saber a idade?");
            string resposta1 = Console.ReadLine();

            if(resposta1 == "sim"){
                Console.WriteLine("");
                Console.WriteLine("A idade dessa pessoa seria " + idadepessoa);

            Console.WriteLine("");
            Console.WriteLine("Vamos aproveitar e converter para semanas também?");
            string resposta2 = Console.ReadLine();
            Console.WriteLine("");

            if(resposta2 == "sim"){
                Console.WriteLine("");
                Console.WriteLine("Bora lá!");
                Console.WriteLine("");
            }else{
                Console.WriteLine("");
                Console.WriteLine("Poxa, ajuda o programa vai, vamos lá!");
                Console.WriteLine("");
            
            Console.WriteLine("A idade em semanas é " + semanas);

            Console.WriteLine("");
            Console.WriteLine("Bom, é isso que sou capaz de fazer! Obrigado pela preferência! <3");
                
            }


            }
        }
    }
}
