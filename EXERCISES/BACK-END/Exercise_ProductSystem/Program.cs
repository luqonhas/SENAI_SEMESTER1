using System;

namespace Backend_SistemaDeProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variaveis:
            double[] promocaofinal = new double[10];
            double valor;
            int[] porcentagem = new int[10];
            int[] quantidade = new int[10];
            string[] vaiterpromo = new string[10];
            double[] precosprodutos = new double[10];
            string[] nomesprodutos = new string[10];
            int contador = 0;
            string opcoes;
            bool senhacerta;
            string naocadastrado;
            // string username;
            string senha;
            // string[] usernamecadastro = new string[1];
            // string[] senhacadastro = new string[1];


            Console.Clear();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Seja bem vindo às Casas da Bahia!");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Aproveite as nossas promoções da BLACK FRAUDE!");
            Console.WriteLine("");

            Console.WriteLine("Você está cadastrado em nosso site? s/n");
            naocadastrado = Console.ReadLine();

            if(naocadastrado == "n"){
                //Criar conta
            }else{}

            do{
                Console.Clear();
                Console.WriteLine("LOGIN:");
                Console.WriteLine("");

                Console.Write("Digite a sua senha: ");
                senha = Console.ReadLine();
                senhacerta = Login(senha);               
            }while(!senhacerta);

            do{
                Console.WriteLine("");
                Console.WriteLine("MENU:");
                Console.WriteLine("");
                Console.WriteLine("[1] Cadastro de produtos;");
                Console.WriteLine("[2] Listagem de produtos;");
                Console.WriteLine("[3] Mostrar menu;");
                Console.WriteLine("[0] Sair.");
                opcoes = Console.ReadLine();

                switch(opcoes){
                
                    case "1":
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("Cadastro de produtos:");
                        Console.WriteLine("");

                        if(quantidade[contador] > 10){
                            Console.WriteLine("");
                            Console.WriteLine("Ops, o valor de produtos passou de 10...");
                            Console.WriteLine("Tente novamente com uma quantidade menor que 10!");
                            Console.WriteLine("");
                        }

                        if(contador < 10){
                            Console.Write($"Digite o nome do {contador+1}º produto: ");
                            nomesprodutos[contador] = Console.ReadLine();

                            Console.WriteLine("");
                            Console.Write("Digite o preço do produto: ");
                            precosprodutos[contador] = float.Parse(Console.ReadLine());
                            Console.WriteLine("");

                            Console.Write("");
                            Console.WriteLine("Digite a quantidade de produtos: ");
                            quantidade[contador] = int.Parse(Console.ReadLine());

                            valor = quantidade[contador] * precosprodutos[contador];

                            Console.WriteLine("Este produto terá alguma promoção? s/n");
                            vaiterpromo[contador] = Console.ReadLine();
                            Console.Write("");

                            Console.Write("");
                            if(vaiterpromo[contador] != "s"){
                                Console.Write("");
                                Console.WriteLine("Ok, sem promoção.");
                                Console.Write("");

                                promocaofinal[contador] = valor;

                                Console.WriteLine($"Este produto(s) não está incluído na promoção, portanto, seu valor será: {promocaofinal[contador].ToString("N2")} reais.");
                                Console.Write("");
                            }else{
                                Console.WriteLine("");
                                Console.WriteLine("Quantos porcento vai ter de promoção? 'valores inteiros'");
                                porcentagem[contador] = int.Parse(Console.ReadLine());

                                if(quantidade[contador] <= 10){
                                    double calculoporcentagem = porcentagem[contador] / 100;
                                    double valorfinal = valor * calculoporcentagem;
                                    promocaofinal[contador] = valor - valorfinal;

                                    Console.WriteLine("");
                                    Console.WriteLine($"Com a promoção de {porcentagem[contador]}%, o valor final deste produto será: {promocaofinal[contador].ToString("N2")} reais.");
                                }
                            }
                            
                            contador++;//pro contador ir com aumentando a sua contagem

                        }else{
                            Console.WriteLine("");
                            Console.WriteLine("Número de produtos cadastrados excedido!");
                        }
                        break;

                    case "2":
                        Console.WriteLine("");
                        Console.WriteLine("Total de produtos cadastrados nesta seção:");
                        Console.WriteLine("");
                        for (var i = 0; i < contador; i++){
                            Console.WriteLine($"| Produto: {nomesprodutos[i]} || Preço cada: {precosprodutos[i].ToString("N2")} reais || Quantidade: {quantidade[i]} || Promoção: {vaiterpromo[i]} || Porcentagem: {porcentagem[i]}% || Valor total: {promocaofinal[i].ToString("N2")} reais |");
                            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
                        }
                        break;

                    case "0":
                        Console.WriteLine("Obrigado por comprar nas Casas da Bahia!");
                        break;

                    default:
                        Console.WriteLine("Valor inválido!");
                        break;
                }

            } while (opcoes != "0");
            
            



            //Funções:
            bool Login(string senha){
                if(senha == "123"){
                    return true;
                }else{
                    Console.WriteLine("---------------");
                    Console.WriteLine("Senha inválida!");
                    Console.WriteLine("---------------");
                    return false;
                }
            }




            // bool Cadastro(string naocadastrado){

            //     Console.WriteLine("");
            //     Console.Write("Digite o seu username: ");
            //     username1 = Console.ReadLine();

            //     Console.WriteLine("");
            //     Console.Write("Digite a sua senha: ");

            //     return new []{username1};
            // }
        }
    }
}
