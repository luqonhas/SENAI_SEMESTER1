using System;
using System.Collections.Generic;
using Exercise_ListOfObjects.Class;

namespace Exercise_ListOfObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            // criando a lista:
            List<Produto> produtos = new List<Produto>();

            // adicionando produtos na lista:
            produtos.Add(new Produto(12345, "iPhone X", 3299.90f));
            produtos.Add(new Produto(54321, "Motorola One Action", 1299.00f));
            produtos.Add(new Produto(67890, "Samsung S20+", 4299.90f));
            produtos.Add(new Produto(12345, "iPhone 11", 6299.90f));
            produtos.Add(new Produto(13579, "Nokia Tijolão", 199.90f));

            Console.WriteLine("LISTA DE PRODUTOS: \n");

            foreach (Produto itens in produtos){
                Console.WriteLine($"O smartphone {itens.Name} está com o preço de {itens.Price.ToString("N2")} reais.");
                System.Threading.Thread.Sleep(1000);
            }

            // para remover itens individualmente pelo índice:
            // produtos.RemoveAt(3);

            // para remover todos os itens com o mesmo código/nome/preço:
            produtos.RemoveAll(x => x.Code == 12345);

            System.Threading.Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("\nLISTA DE PRODUTOS ALTERADA: \n");

            foreach (Produto itens in produtos){
                Console.WriteLine($"O smartphone {itens.Name} está com o preço de {itens.Price.ToString("N2")} reais.");
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
