using System;

namespace Backend_MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {   
            string refazer = "sim";
            while(refazer == "sim"){

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("-------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Olá, sou a tabuada C#, estou à sua disposição! =)");//
                Console.ForegroundColor = ConsoleColor.Red;//
                Console.WriteLine("-------------------------------------------------");
                System.Threading.Thread.Sleep(700);

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Qual tabuada você quer?");//
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(" (apenas números)");
                Console.ForegroundColor = ConsoleColor.Yellow;
                int tabuada = int.Parse(Console.ReadLine());//
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.White;
                System.Threading.Thread.Sleep(700);
                Console.WriteLine($"A tabuada de {tabuada} é:");//

                int resultado = 0;
            
                for(int contador = 0; contador <= 10; contador++){
                    resultado = tabuada * contador;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"{tabuada} x {contador} = ");//
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(resultado);

                    System.Threading.Thread.Sleep(850);
                }

                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Gostaria de refazer a operação?");
                System.Threading.Thread.Sleep(500);
                Console.ForegroundColor = ConsoleColor.Yellow;
                refazer = Console.ReadLine();

                if(refazer != "sim"){
                    System.Threading.Thread.Sleep(650);
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ótimo! Agradecemos a preferência! =)");
                }
                //dentro da while
            }
        }
    }
}
