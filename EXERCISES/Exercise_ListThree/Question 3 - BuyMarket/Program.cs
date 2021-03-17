using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            float preco_doritos = 5.90f;
            float preco_cebolitos = 4.80f;
            float preco_baconzitos = 4.00f;
            float valor;
            string refazer = "sim";
            double desconto;

            do{    
                Console.WriteLine("Qual salgadinho você quer? 'doritos', 'cebolitos' ou 'baconzitos'");
                string salgadinho = Console.ReadLine();
                Console.WriteLine("");

                Console.WriteLine($"Quantos {salgadinho} você quer?");
                int quantidade = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                //doritos 0
                if(salgadinho.ToUpper() == "doritos"){
                    valor = (quantidade * preco_doritos);

                    if(quantidade <= 5){
                        double porcentagem = valor * 0.02;
                        desconto = valor - porcentagem;
                        Math.Round(desconto,2);

                        Console.WriteLine($"Cada Doritos está {preco_doritos} e, com essa quatidade que você pegou, terá um desconto de 2%.");
                        Console.WriteLine("");
                        Console.WriteLine($"O valor desse(s) {quantidade} Doritos é {desconto.ToString("N2")}");
                    }

                    if(quantidade > 5 && quantidade <= 10){
                        double porcentagem = valor * 0.03;
                        desconto = valor - porcentagem;
                        Math.Round(desconto,2);

                        Console.WriteLine($"Cada Doritos está {preco_doritos} e, com essa quatidade que você pegou, terá um desconto de 2%.");
                        Console.WriteLine("");
                        Console.WriteLine($"O valor desse(s) {quantidade} Doritos é {desconto.ToString("N2")}");
                    }

                    if(quantidade > 10){
                        double porcentagem = valor * 0.05;
                        desconto = valor - porcentagem;
                        Math.Round(desconto,2);

                        Console.WriteLine($"Cada Doritos está {preco_doritos} e, com essa quatidade que você pegou, terá um desconto de 2%.");
                        Console.WriteLine("");
                        Console.WriteLine($"O valor desse(s) {quantidade} Doritos é {desconto.ToString("N2")}");
                    }
                }
                //doritos 1

                //cebolitos 0
                if(salgadinho.ToUpper() == "cebolitos"){
                    valor = (quantidade * preco_cebolitos);

                    if(quantidade <= 5){
                        double porcentagem = valor * 0.02;
                        desconto = valor - porcentagem;
                        Math.Round(desconto,2);

                        Console.WriteLine($"Cada Cebolitos está {preco_cebolitos} e, com essa quatidade que você pegou, terá um desconto de 2%.");
                        Console.WriteLine("");
                        Console.WriteLine($"O valor desse(s) {quantidade} Cebolitos é {desconto.ToString("N2")}");
                    }

                    if(quantidade > 5 && quantidade <= 10){
                        double porcentagem = valor * 0.03;
                        desconto = valor - porcentagem;
                        Math.Round(desconto,2);

                        Console.WriteLine($"Cada Cebolitos está {preco_cebolitos} e, com essa quatidade que você pegou, terá um desconto de 3%.");
                        Console.WriteLine("");
                        Console.WriteLine($"O valor desse(s) {quantidade} Cebolitos é {desconto.ToString("N2")}");
                    }

                    if(quantidade > 10){
                        double porcentagem = valor * 0.05;
                        desconto = valor - porcentagem;

                        Console.WriteLine($"Cada Cebolitos está {preco_cebolitos} e, com essa quatidade que você pegou, terá um desconto de 5%.");
                        Console.WriteLine("");
                        Console.WriteLine($"O valor desse(s) {quantidade} Cebolitos é {desconto.ToString("N2")}");
                    }
                }
                //cebolitos 1

                //baconzitos 0                        
                if(salgadinho.ToUpper() == "baconzitos"){
                    valor = (quantidade * preco_baconzitos);

                    
                    if(quantidade <= 5){
                        double porcentagem = valor * 0.02;
                        desconto = valor - porcentagem;
                        
                        Console.WriteLine($"Cada Baconzitos está {preco_baconzitos} e, com essa quatidade que você pegou, terá um desconto de 2%.");
                        Console.WriteLine("");
                        Console.WriteLine($"O valor desse(s) {quantidade} Baconzitos é {desconto.ToString("N2")}");
                    }

                    if(quantidade > 5 && quantidade <= 10){
                        double porcentagem = valor * 0.03;
                        desconto = valor - porcentagem;
                        Math.Round(desconto,2);

                        Console.WriteLine($"Cada Baconzitos está {preco_baconzitos} e, com essa quatidade que você pegou, terá um desconto de 3%.");
                        Console.WriteLine("");
                        Console.WriteLine($"O valor desse(s) {quantidade} Baconzitos é {desconto.ToString("N2")}");
                    }

                    if(quantidade > 10){
                        double porcentagem = valor * 0.05;
                        desconto = valor - porcentagem;
                        Math.Round(desconto,2);

                        Console.WriteLine($"Cada Baconzitos está {preco_baconzitos} e, com essa quatidade que você pegou, terá um desconto de 5%.");
                        Console.WriteLine("");
                        Console.WriteLine($"O valor desse(s) {quantidade} Baconzitos é {desconto.ToString("N2")}");
                    }
                }
                //baconzitos 1

                Console.WriteLine("");
                Console.WriteLine("Deseja comprar algo novamente?");
                refazer = Console.ReadLine();
                Console.WriteLine("");

            }while(refazer == "sim");

            Console.WriteLine("Ok, tenha um bom dia!");
            Console.WriteLine("");
        }
    }
}
