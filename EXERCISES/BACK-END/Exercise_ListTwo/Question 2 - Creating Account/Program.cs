using System;

namespace question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("---------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Vamos criar a sua conta do E-Players!");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("");

            string nick;
            string senha;
            string csenha;

            do{
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Gostaria de ser chamado como?");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Nickname: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                nick = Console.ReadLine();
                Console.WriteLine("");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Qual será a sua senha?");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Senha: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                senha = Console.ReadLine();
                Console.WriteLine("");

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Confirme a sua senha: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                csenha = Console.ReadLine();

                if(senha == nick || csenha != senha){
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Erro!!!");
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Talvez você tenha colocado o seu nickname na senha \nou as suas senhas não estão iguais.");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("---------------------------------------------------------------");
                    Console.WriteLine("");
                }
            } while(senha == nick || csenha != senha);

            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Conta criada!");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Bem vindo(a) {nick}, agora você faz parte da Liga E-Players!");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
