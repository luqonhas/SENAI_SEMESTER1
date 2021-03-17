using System;
using Exercise_ArgumentObject.Class;

namespace Exercise_ArgumentObject
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaração de variaveis:
            string resposta;

            Console.Clear();
            Console.WriteLine("Seja bem vindo à LUQONHAS STORE!\n");

            // produtos:
            Produto p1 = new Produto(1, "Minecraft", 109.90f);
            Produto p2 = new Produto(12, "Cyberpunk 2077", 270.99f);
            Produto p3 = new Produto(123, "God of War", 148.80f);
            Produto p4 = new Produto(1234, "Spider-Man: Miles Morales", 150f);
            Produto p5 = new Produto(12345, "Celeste", 27.90f);

            // adicionando os produtos no carrinho:
            Carrinho carrinho = new Carrinho();
            carrinho.AdicionarProduto(p1);
            carrinho.AdicionarProduto(p2);
            carrinho.AdicionarProduto(p3);
            carrinho.AdicionarProduto(p4);
            carrinho.AdicionarProduto(p5);

            // mostrar nosso carrinho:
            carrinho.MostrarProdutos();

            Console.WriteLine("");
            Console.WriteLine("Gostaria de remover ou trocar algum produto? s/n");
            resposta = Console.ReadLine();
            if(resposta == "s" || resposta == "S"){
                Console.WriteLine("");
                Console.WriteLine("Remover ou alterar? r/a");
                resposta = Console.ReadLine();

            }else{
                Console.WriteLine("Ok, tudo bem!");
            }
        }
    }
}
