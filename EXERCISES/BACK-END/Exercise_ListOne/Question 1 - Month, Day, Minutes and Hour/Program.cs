using System;

namespace questão_1___mes__dia__min_e_hr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, seja bem-vindo(a), este é um programa conversor de idades!");
            Console.WriteLine("");

            Console.WriteLine("Primeiramente, qual a sua idade?");
            int idade = int.Parse(Console.ReadLine());

            if(idade > 0){
                Console.WriteLine("");
                Console.WriteLine("Aí sim!");
            
            int meses = (idade * 12);
            int dias = (idade * 365);
            int horas = (idade * 8760);
            int minutos = (idade * 525600);



            Console.WriteLine("Bom, agora que sabemos a sua idade...");
            Console.WriteLine("");

            Console.WriteLine("Você gostaria de converter sua idade em meses, dias, horas ou minutos? Vamos lá? 'sim'");
            string SorN = Console.ReadLine();


            if(SorN == "sim"){
                Console.WriteLine("Então, Vamos lá!");
                Console.WriteLine("");
            }

            Console.WriteLine("Gostaria de converter para meses, dias, horas ou minutos?");
            string opcoes = Console.ReadLine();
            Console.WriteLine("");

            if(opcoes == "meses"){
                Console.WriteLine("");
                Console.WriteLine("Sua idade em meses é de " + meses);
            }

            if(opcoes == "dias"){
                Console.WriteLine("");
                Console.WriteLine("Sua idade em dias é de " + dias);
            }

            if(opcoes == "horas"){
                Console.WriteLine("");
                Console.WriteLine("Sua idade em horas é de " + horas);
            }

            if(opcoes == "minutos"){
                Console.WriteLine("");
                Console.WriteLine("Sua idade em minutos é de " + minutos);
            }
            
            }
        }
    }
}
