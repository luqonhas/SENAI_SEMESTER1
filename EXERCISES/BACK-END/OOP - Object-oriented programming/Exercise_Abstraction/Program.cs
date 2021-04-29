using System;
using Exercise_Abstraction.Class;
using System.Threading;

namespace Exercise_Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarando variaveis:
            int opcoesMenuPrincipal;
            int opcoesMenuDePagamento;
            int opcoesDoCartao;
            int opcoesDeDebito;
            int opcoesDeCredito;
            float receberValor;

            //instanciando classes:
            Boleto boleto = new Boleto();
            Pagamento pagamento = new Pagamento();

            Console.Clear();
            Console.WriteLine("Olá! Seja bem vindo(a) ao BancoLQ!");
            Console.WriteLine("");

            do{
                Console.ForegroundColor = ConsoleColor.Yellow;       
                Console.WriteLine("MENU PRINCIPAL:"); 
                Console.WriteLine("[1] - OPÇÕES DE PAGAMENTO"); 
                Console.WriteLine("[0] - SAIR");
                opcoesMenuPrincipal = int.Parse(Console.ReadLine());
                Console.WriteLine(""); 
                Console.ResetColor();       

            if(opcoesMenuPrincipal == 1){
                do{            
                    Console.ForegroundColor = ConsoleColor.Green;       
                    Console.WriteLine("MENU DE PAGAMENTO:"); 
                    Console.WriteLine("[1] - BOLETO"); 
                    Console.WriteLine("[2] - CARTÃO");
                    Console.WriteLine("[0] - VOLTAR AO MENU PRINCIPAL");
                    opcoesMenuDePagamento = int.Parse(Console.ReadLine());
                    Console.WriteLine(""); 
                    Console.ResetColor();

                    switch(opcoesMenuDePagamento){
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("PAGAMENTO COM BOLETO:");
                            boleto.RegistrarCodigoDeBarras();
                            Console.WriteLine(""); 
                            boleto.GerarBoleto();
                            Console.Write("");
                            Console.Write("Digite o valor a ser pago: "); 
                            receberValor = float.Parse(Console.ReadLine());
                            pagamento.ReceberValor(receberValor);
                            Console.WriteLine(""); 
                            Console.WriteLine(boleto.Desconto(receberValor)); 
                            Console.WriteLine("");
                            Console.Write("Data e hora que foi pago: ");
                            Console.WriteLine(boleto.Data = DateTime.Now);
                            Console.WriteLine(""); 
                            Console.ResetColor();
                            break;

                        case 2:
                            do{
                                Console.ForegroundColor = ConsoleColor.Blue;       
                                Console.WriteLine("OPÇÕES DE CARTÃO:"); 
                                Console.WriteLine("[1] - DADOS DO CARTÃO"); 
                                Console.WriteLine("[2] - DÉBITO");
                                Console.WriteLine("[3] - CRÉDITO");
                                Console.WriteLine("[0] - SAIR");
                                opcoesDoCartao = int.Parse(Console.ReadLine());
                                Console.WriteLine(""); 
                                Console.ResetColor();

                                switch(opcoesDoCartao){
                                    case 1:
                                        Console.WriteLine("DADOS DO CARTÃO:");
                                        //mostrar bandeira padrão
                                        //mostrar número padrão
                                        //mostrar titular padrão
                                        //mostrar cvv padrão
                                        break;
                                    
                                    case 2:
                                        do{
                                            Console.ForegroundColor = ConsoleColor.Magenta;       
                                            Console.WriteLine("OPÇÕES DE DÉBITO:"); 
                                            Console.WriteLine("[1] - SALDO DISPONÍVEL"); 
                                            Console.WriteLine("[2] - PAGAR");
                                            Console.WriteLine("[0] - SAIR");
                                            opcoesDeDebito = int.Parse(Console.ReadLine());
                                            Console.WriteLine(""); 
                                            Console.ResetColor();

                                            if(opcoesDeDebito == 1){
                                                Console.WriteLine("SALDO DISPONÍVEL NO DÉBITO:");
                                                //mostrar saldo disponível de débito padrão
                                                    //se ultrapassar o valor pago, ficará negativo
                                                    //se pago, descontar
                                            }
                                            if(opcoesDeDebito == 2){
                                                Console.WriteLine("SALDO DISPONÍVEL NO CRÉDITO:");
                                                //digite o valor a ser pago
                                                //criar metodo de desconto
                                                //mostrar valor final a ser pago
                                                //mostrar data e hora que foi pago
                                            }
                                        } while (opcoesDeDebito != 0);
                                        break;

                                        case 3:
                                        do{
                                            Console.ForegroundColor = ConsoleColor.Magenta;       
                                            Console.WriteLine("OPÇÕES DE CRÉDITO:"); 
                                            Console.WriteLine("[1] - SALDO DISPONÍVEL"); 
                                            Console.WriteLine("[2] - PAGAR");
                                            Console.WriteLine("[0] - SAIR");
                                            opcoesDeCredito = int.Parse(Console.ReadLine());
                                            Console.WriteLine(""); 
                                            Console.ResetColor();

                                            if(opcoesDeCredito == 1){
                                                //mostrar saldo disponível de débito padrão
                                                    //se ultrapassar o valor pago, ficará negativo
                                                    //se pago, descontar
                                            }
                                            if(opcoesDeCredito == 2){
                                                //digite o valor a ser pago
                                                //criar metodo de desconto
                                                //mostrar valor final a ser pago
                                                //mostrar data e hora que foi pago
                                            }
                                        } while (opcoesDeCredito != 0);
                                        break;
                                }

                            }while(opcoesDoCartao != 0);
                            break;

                    }     

                }while (opcoesMenuDePagamento != 0);
            }//fim MENU DE PAGAMENTO

            } while (opcoesMenuPrincipal != 0);
        }//fim MENU PRINCIPAL
    }
}
