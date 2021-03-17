using System;

namespace Idades
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Bem vindo a seletiva para time de csgo!");
            Console.WriteLine("---------------------------------------");

            Console.WriteLine("Você gostaria de participar? 'sim' ou 'não'");
            string resposta = Console.ReadLine();

            // os dois == significam que está comparando
            if(resposta == "sim"){
            }else{
                Console.WriteLine("belê, passar bem!");
            }

                Console.WriteLine("daora, agora vamos analisar o seu curriculo");

                Console.WriteLine("digite sua média escolar");
                int mediaesc = int.Parse(Console.ReadLine());

                Console.WriteLine("digite a sua quantidade de faltas");
                int faltasesc = int.Parse(Console.ReadLine());

                if(mediaesc >= 7 && faltasesc <=5){
                    Console.WriteLine("bem-vindo ao time!");
                }else{
                    Console.WriteLine("melhore a sua média e/ou suas faltas para conseguir entrar no time!");
                }

        }
    }
}
