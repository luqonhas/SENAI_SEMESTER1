using System;

namespace AlternativasFarois_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // abertura 0
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Olá, seja bem vindo(a) à central de dúvidas sobre as cores dos semáfaros!");
            // abertura 1



            // processo 0
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("O farol está com que cor? 'verde', 'amarelo' ou 'vermelho'");
            Console.ForegroundColor = ConsoleColor.White;
            string cor = Console.ReadLine();
            // processo 1



            // cor vermelha 0
            Console.WriteLine("");
            if(cor == "vermelho"){
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Você aceita tomar uma multa? ('sim' ou 'não')");
                Console.ForegroundColor = ConsoleColor.White;
                string simR = Console.ReadLine();


                // parte do sim 0
                if(simR == "sim"){
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Avance o farol!");                   
                }

                if(simR == "s"){
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Avance o farol!");                   
                }
                // parte do sim 1


                // parte do não 0
                if(simR == "não"){
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Pare o carro!");
                }

                if(simR == "nao"){
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Pare o carro!");
                }

                if(simR == "n"){
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Pare o carro!");
                }
                // parte do não 1
            }
            // cor vermelha 1



            // cor amarela 0
            if(cor == "amarelo"){
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Você está atrasado? 'sim' ou 'não'");
                Console.ForegroundColor = ConsoleColor.White;
                string simY = Console.ReadLine();
                

                // parte do sim 0
                if(simY == "sim"){
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Avance o farol!");
                }

                if(simY == "s"){
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Avance o farol!");
                }
                // parte do sim 1


                // parte do não 0
                if(simY == "não"){
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Desacelere, pare e espere o farol ficar verde!");
                }

                if(simY == "nao"){
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Desacelere, pare e espere o farol ficar verde!");
                }

                if(simY == "n"){
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Desacelere, pare e espere o farol ficar verde!");
                }
                // parte do não 1
            }
            // cor amarela 1



            // cor verde 0
            if(cor == "verde"){
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Pode continuar avançando!");
            }
            // cor verde 1


            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Pronto, após ter tirado suas dúvidas, pode prosseguir sua viagem tranquilamente! :)");
        }
    }
}