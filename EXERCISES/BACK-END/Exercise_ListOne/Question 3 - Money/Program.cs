using System;

namespace questão_3___dinheiro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, seja bem vindo(a) ao sistema de salário de empresas!");
            Console.WriteLine("");

            Console.WriteLine("Quanto é o seu salário?");
            double salario = double.Parse(Console.ReadLine());

            double aumento = salario * 0.30;
            double reajuste = salario + aumento;

            if(salario < 500){
                Console.WriteLine("");
                Console.WriteLine("Você receberá um aumento de 30%!");
                Console.WriteLine("Seu salário de " + salario + " reais, com o aumento, seu salário para o valor de " + reajuste + " reais.");
            }else{
                Console.WriteLine("");
                Console.WriteLine("Você não receberá um aumento, pois o valor do seu salário está alto.");
                Console.WriteLine("");
            }

        }
    }
}
