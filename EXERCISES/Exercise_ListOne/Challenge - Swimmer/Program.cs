using System;

namespace desafio___nadador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, bem vindo à academia de natação, antes de começar a nadar, você terá que saber em qual categoria está!");
            Console.WriteLine("");

            Console.WriteLine("Qual a sua idade? 'digite o número'");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            if(idade >= 5 && idade <= 7){
            Console.WriteLine("Parabéns, você entrou para a categoria Infantil A, pois sua idade está entre os 5 - 7 anos!");
            Console.WriteLine("");
            }

            if(idade >= 8 && idade <= 10){
            Console.WriteLine("Parabéns, você entrou para a categoria Infantil B, pois sua idade está entre os 8 - 10 anos!");
            Console.WriteLine("");
            }

            if(idade >= 11 && idade <= 13){
            Console.WriteLine("Parabéns, você entrou para a categoria Juvenil A, pois sua idade está entre os 11 - 13 anos!");
            Console.WriteLine("");
            }

            if(idade >= 14 && idade <= 17){
            Console.WriteLine("Parabéns, você entrou para a categoria Juvenil B, pois sua idade está entre os 14 - 17 anos!");
            Console.WriteLine("");
            }

            if(idade >= 18){
            Console.WriteLine("Parabéns, você entrou para a categoria Sênior, pois sua idade está entre os maiores de 18 anos!");
            Console.WriteLine("");
            }
        }
    }
}
