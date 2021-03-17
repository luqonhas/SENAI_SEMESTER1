using System;

namespace Project_Products.Class
{
    public class Login
    {
        public bool Logged { get; set; }
        
        public Login(){
            Logar();
            if(Logged == true){
                GerarMenu();
            }
        }
        public void GerarMenu(){
            int respostaMenu;
            Produto produto = new Produto();
            Marca marca = new Marca();

            do{
                    Console.WriteLine("MENU PRINCIPAL");
                    Console.WriteLine("[1] - Cadastrar Marca");
                    Console.WriteLine("[2] - Listar Marcas");
                    Console.WriteLine("[3] - Deletar Marca");
                    Console.WriteLine("");
                    Console.WriteLine("[4] - Cadastrar Produto");
                    Console.WriteLine("[5] - Listar Produtos");
                    Console.WriteLine("[6] - Deletar Produto");
                    Console.WriteLine("");
                    Console.WriteLine("[0] - SAIR");
                    respostaMenu = int.Parse(Console.ReadLine());

                    switch (respostaMenu){
                        case 1:
                        marca.Cadastrar();
                        Console.WriteLine("");
                        break;

                        case 2:
                        marca.Listar();
                        Console.WriteLine("");
                        break;

                        case 3:
                        Console.WriteLine("Digite o código de uma marca que deseja excluir:");
                        int codigoMarca = int.Parse(Console.ReadLine());
                        marca.Deletar(codigoMarca);
                        Console.WriteLine("");
                        break;

                        case 4:
                        produto.Cadastrar();
                        Console.WriteLine("");
                        break;

                        case 5:
                        produto.Listar();
                        Console.WriteLine("");
                        break;

                        case 6:
                        Console.WriteLine("Digite o código de um produto que deseja excluir:");
                        int codigoProduto = int.Parse(Console.ReadLine());
                        produto.Deletar(codigoProduto);
                        Console.WriteLine("");
                        break;
                    }
                }while(respostaMenu != 0);
        }
        public void Logar(){
            Usuario user = new Usuario();
            Console.WriteLine("Digite o seu e-mail:");
            string email = Console.ReadLine();
            Console.WriteLine("");
            
            Console.WriteLine("Digite a sua senha:");
            string senha = Console.ReadLine();
            Console.WriteLine("");
            
            if(email == user.Email && senha == user.Password){
                Logged = true;
                Console.WriteLine("Login efetuado com sucesso!");
                Console.WriteLine("");
            }else{
                Console.WriteLine("Tem algo errado aí bicho, tente novamente!");
            }
        }
        public void Deslogar(){
            Logged = false;
        }
    }
}