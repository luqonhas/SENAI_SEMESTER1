using System;
using Exercise_Interfaces.Class;

namespace Exercise_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho carrinho = new Carrinho();
            
            Produto p1 = new Produto();
            p1.Code = 123;
            p1.Name = "Doritos";
            p1.Price = 6.90f;

            Produto p2 = new Produto();
            p1.Code = 1234;
            p1.Name = "Cebolitos";
            p1.Price = 4.90f;

            Produto p3 = new Produto();
            p1.Code = 12345;
            p1.Name = "Ruffles";
            p1.Price = 5.90f;

            carrinho.Cadastrar(p1);
            carrinho.Cadastrar(p2);
            carrinho.Cadastrar(p3);

            carrinho.Listar();

            Console.ForegroundColor = ConsoleColor.DarkGreen;

            carrinho.Alterar(p2.Code, p3);

            carrinho.Listar();

            Console.ForegroundColor = ConsoleColor.Red;

            carrinho.Deletar(p1.Code);
            
            carrinho.Listar();
        }
    }
}
