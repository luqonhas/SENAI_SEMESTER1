using System;
using Exercise_ConstructorMethods.Class;

namespace Exercise_ConstructorMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaração de variaveis:
            int codigo;
            string nome;
            string descricao;
            int emEstoque;

            Console.Clear();
            Console.WriteLine("Seja bem vindo ao mercado Luqonhas!");
            Console.WriteLine("");

            Console.Write("Digite o código de mentirinha do produto: ");
            codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            
            Console.Write("Digite o nome de mentirinha do produto: ");
            nome = Console.ReadLine();
            Console.WriteLine("");

            Console.Write("Digite a descrição de mentirinha do produto: ");
            descricao = Console.ReadLine();
            Console.WriteLine("");

            Console.Write("Digite o número de mentirinha de produtos em estoque: ");
            emEstoque = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Produto produto1 = new Produto(codigo, nome, descricao, emEstoque);
            Console.WriteLine("");

            Console.WriteLine("INFORMAÇÕES DO PRODUTO CADASTRADO:");
            Console.WriteLine("");
            Console.WriteLine($"CÓDIGO: {produto1.Codigo}");
            Console.WriteLine($"NOME: {produto1.Nome}");
            Console.WriteLine($"DESCRIÇÃO: {produto1.Descricao}");
            Console.WriteLine($"ESTOQUE: {produto1.EmEstoque}");
        }
    }
}
