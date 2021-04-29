using System;

namespace Backend_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] produtos = {"maça", "banana", "maracujá", "limão", "morango", "manga", "laranja", "mexirica", "carambola", "goiaba"};
            double[] precos = {2.00, 3.00, 5.00, 1.00, 6.00, 6.00, 4.00, 3.50, 2.50, 3.50};
            string refazer = "sim";

            Console.WriteLine("Olá, sou a feira virtual! Como posso ajudar?");
            Console.WriteLine("");

            Console.WriteLine("Você gostaria de criar sua lista ou usar a padrão? 'criar' ou 'padrao'");
            string alternativas = Console.ReadLine();

            if(alternativas == "criar"){
                do{
                    Console.WriteLine("Qual o tamanho que você quer que a lista tenha? 'apenas números'");
                    int tamanho = int.Parse(Console.ReadLine());

                    string[] criar_produtos = new string[tamanho];

                    for(int i = 0; i < criar_produtos.Length; i++){
                        Console.WriteLine("");
                        Console.WriteLine("Digite o nome do produto:");
                        criar_produtos[i] = Console.ReadLine();
                    }

                        Console.WriteLine("");
                        Console.WriteLine("Sua lista é:");

                    for(var i = 0; i < criar_produtos.Length; i++){
                        Console.WriteLine(criar_produtos[i]);
                    }

                    Console.WriteLine("");
                    Console.WriteLine("Você gostaria de refazer?");
                    refazer = Console.ReadLine();

                } while(refazer == "sim");
                
                Console.WriteLine("");
                Console.WriteLine("Ótimo, obrigado pela preferência");
            }
            
        }
    }
}
