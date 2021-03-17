using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            string refazer;

            do{
                Console.WriteLine("Qual tabuada do 1 - 10 você quer?");
                int tabuada = int.Parse(Console.ReadLine());

                for (int i = 0; i < 1; i++){
                    for (int i2 = 0; i2 < 11; i2++){
                        int resultado = tabuada * i2;

                        Console.WriteLine($"{tabuada} x {i2} = {resultado}");
                    }
                    
                }
                Console.WriteLine("Deseja refazer a operação?");
                refazer = Console.ReadLine();
            }while(refazer == "sim");

            Console.WriteLine("Ok, tenha um bom dia!");
            
        }
    }
}
