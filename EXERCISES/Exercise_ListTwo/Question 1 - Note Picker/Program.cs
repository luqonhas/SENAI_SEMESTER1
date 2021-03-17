using System;

namespace question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota;

            do{
                Console.WriteLine("");
                Console.WriteLine("Digite a sua nota:");
                nota = float.Parse(Console.ReadLine());

                if(nota < 0 || nota > 10){
                    Console.WriteLine("");
                    Console.WriteLine("Nota inválida.");
                }
            }while(nota < 0 || nota > 10);

            Console.WriteLine("");
            Console.WriteLine("Nota aceita!");
        }
    }
}
