using System;

namespace Backend_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Olá, fui programada para ser sua calculadora, estou à sua disposição! =)");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Qual operação deseja fazer?");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" adicao / subtracao / multiplicacao / divisao");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string operacao = Console.ReadLine().ToLower();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("");
            Console.WriteLine("Boa!");
            Console.WriteLine("");
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite o seu primeiro número:");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            double num1 = double.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("");
            Console.WriteLine("Ótimo!");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite o seu segundo número:");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            double num2 = double.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("");
            Console.WriteLine("Daora!");
            Console.WriteLine("");

            double resultado = 0;

            

            switch(operacao){ // string q lê a operação

                case "adicao": // a operação q a pessoa escolher
                    resultado = num1 + num2; // a soma
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Prontinho!");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("");
                    Console.WriteLine($"O resultado de {num1} + {num2} é igual à {resultado}");
                    break; // para "quebrar" o comando desse case

                case "subtracao":
                    resultado = num1 - num2;
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Prontinho!");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("");
                    Console.WriteLine($"O resultado de {num1} + {num2} é igual à {resultado}");
                    break;

                case "multiplicacao":
                    resultado = num1 * num2;
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Prontinho!");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("");
                    Console.WriteLine($"O resultado de {num1} + {num2} é igual à {resultado}");
                    break;

                case "divisao":
                    resultado = num1 / num2;
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Prontinho!");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("");
                    Console.WriteLine($"O resultado de {num1} + {num2} é igual à {resultado}");
                    break;     

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Operação inválida! =(");
                    break;           
            }
        }
    }
}
