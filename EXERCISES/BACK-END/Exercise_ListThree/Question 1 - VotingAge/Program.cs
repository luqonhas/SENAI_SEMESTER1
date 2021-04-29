using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string refazer = "sim";
            do{
                Console.WriteLine("Digite o ano de seu nascimento:");
                int nascimento = int.Parse(Console.ReadLine());

                int resultado = (2020 - nascimento);

                if(resultado >= 18){
                    Console.WriteLine("");
                    Console.WriteLine($"Você com a idade de {resultado} anos poderá votar neste ano!");
                }else{
                    Console.WriteLine("");
                    Console.WriteLine($"Você com a idade de {resultado} anos não poderá votar neste ano!");
                }

                Console.WriteLine("");
                Console.WriteLine("Gostaria de refazer a operação?");
                refazer = Console.ReadLine();
                
            } while (refazer == "sim");
                Console.WriteLine("");
                Console.WriteLine("Ok, tenha um bom dia!");
                Console.WriteLine("");
            

        }
    }
}
