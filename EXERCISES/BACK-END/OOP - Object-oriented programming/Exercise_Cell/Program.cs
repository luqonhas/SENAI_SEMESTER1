using System;
using System.Threading;
using Exercise_Cell.Class;

namespace Exercise_Cell
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular usuário1 = new Celular();
            Console.Clear();
            int opcoes;
            int opcoes2;
            string mexer;
            int numeroTelefone;
            string contatoExistente;
            string mensagem;

            do{
                Console.WriteLine("MENU PRINCIPAL:");
                Console.WriteLine("[1]- Ligar ou Desligar");
                Console.WriteLine("[2]- Opções");
                Console.WriteLine("[3]- Especificações do Celular");
                Console.WriteLine("[0]- Sair");
                opcoes = int.Parse(Console.ReadLine());

                switch(opcoes){
                    case 1:
                        Console.WriteLine("Gostaria de mexer no celular? 's/n'");
                        mexer = Console.ReadLine();
                        
                        if(mexer == "S" || mexer == "s"){
                            usuário1.Ligar();
                            Console.WriteLine("");
                        }else{
                            usuário1.Desligar();
                            Console.WriteLine("");
                        }
                        break;

                    case 2:
                        do{
                        Console.WriteLine("MENU DE OPÇÕES:");
                        Console.WriteLine("[1]- Fazer Ligação");
                        Console.WriteLine("[2]- Enviar Mensagem");
                        Console.WriteLine("[3]- Voltar ao MENU PRINCIPAL");
                        opcoes2 = int.Parse(Console.ReadLine());

                        switch(opcoes2){
                            case 1:
                                Console.Write("Digite o número de telefone:");
                                numeroTelefone = int.Parse(Console.ReadLine());
                                usuário1.FazerLigação();

                                Thread.Sleep(2000);
                                Console.WriteLine("A ligação caiu para a caixa de mensagens.");
                                break;
                            
                            case 2:
                                Console.Write("Digite o nome do contato que deseja enviar a mensagem: ");
                                contatoExistente = Console.ReadLine();

                                if(contatoExistente == "Lucas" || contatoExistente == "lucas"){
                                    Console.WriteLine("Usuário existente reconhecido");

                                    Console.WriteLine($"Qual mensagem gostaria de enviar para {usuário1.contato}");
                                    mensagem = Console.ReadLine();
                                    usuário1.EnviarMensagem(usuário1.contato);

                                    Console.WriteLine("");
                                    Thread.Sleep(1500);
                                    Console.WriteLine("Oi???");
                                    Console.WriteLine("Quem é??");
                                    Thread.Sleep(700);
                                    Console.WriteLine("Bloqueado!");
                                }else{
                                    Console.WriteLine("Contato não existem/reconhecido");
                                }
                                break;
                                
                        }
                        }while(true);
                        break;
                        
                }



            } while (true);         
        }
    }
}
