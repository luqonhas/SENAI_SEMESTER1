using System;

namespace Ex._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor_gasolina = 5.30;
            double valor_alcool = 4.90;
            double valor;
            
            Console.WriteLine("");
            Console.WriteLine("Você quer abastecer com Álcool(a) ou com Gasolina(g)?");
            string opcoes = Console.ReadLine();
            Console.WriteLine("");

            switch(opcoes){
                case "g":
                    Console.WriteLine("Quantos litros de gasolina você quer abastecer? 'valores inteiros'");
                    int quantidade = int.Parse(Console.ReadLine());

                    valor = quantidade * valor_gasolina;

                    if(quantidade <= 20){
                        double porcentagem = valor * 0.04;
                        double desconto = valor - porcentagem;

                        Console.WriteLine("");
                        Console.WriteLine($"O preço de {quantidade} litros com o desconto de 4% ficará {desconto} reais.");
                    }
                    if(quantidade > 20){
                        double porcentagem = valor * 0.06;
                        double desconto = valor - porcentagem;

                        Console.WriteLine("");
                        Console.WriteLine($"O preço de {quantidade} litros com o desconto de 6% ficará {desconto} reais.");
                    }
                    break;
                
                case "a":
                    Console.WriteLine("Quantos litros de álcool você quer abastecer? 'valores inteiros'");
                    quantidade = int.Parse(Console.ReadLine());

                    valor = quantidade * valor_alcool;

                    if(quantidade <= 20){
                        double porcentagem = valor * 0.03;
                        double desconto = valor - porcentagem;

                        Console.WriteLine("");
                        Console.WriteLine($"O preço de {quantidade} litros com o desconto de 3% ficará {desconto} reais.");
                    }
                    if(quantidade > 20){
                        double porcentagem = valor * 0.05;
                        double desconto = valor - porcentagem;

                        Console.WriteLine("");
                        Console.WriteLine($"O preço de {quantidade} litros com o desconto de 5% ficará {desconto} reais.");
                    }
                    break;
            }        
        }
    }
}
