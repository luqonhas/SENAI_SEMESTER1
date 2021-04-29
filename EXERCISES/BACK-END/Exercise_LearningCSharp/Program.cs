using System;

namespace Exercises_LearningCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu nome?");
            string a = Console.ReadLine();

            string result = "Bem vindo(a), " + a;
            Console.WriteLine(result);

            Console.WriteLine("Digite o primeiro número inteiro:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número inteiro:");
            int num2 = int.Parse(Console.ReadLine());

            int result_count = num1 + num2;

            Console.WriteLine("O resultado da conta: " + num1 + " + " + num2 + "= " + result_count);
            {
                
            }
        }
    }
}
