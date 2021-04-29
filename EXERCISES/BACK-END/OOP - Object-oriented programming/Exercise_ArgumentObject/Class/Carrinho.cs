using Exercise_ArgumentObject.Class;
using System;
using System.Collections.Generic;

namespace Exercise_ArgumentObject
{
    public class Carrinho
    {
        // atributo que vai guardar o valor final do carrinho:
        public float FinalPrice { get; set; }
        
        // criação de uma lista que representa o carrinho:
        List<Produto> carrinho = new List<Produto>();

        // método que vai adicionar os produtos na lista do carrinho:
        public void AdicionarProduto(Produto produto){
            carrinho.Add(produto);
        }

        // método que vai remover os produtos que o cliente querer na lista do carrinho:
        public void RemoverProduto(Produto produto){
            carrinho.Remove(produto);
        }

        // método que vai mostrar os produtos na lista do carrinho:
        public void MostrarProdutos(){
            if(carrinho != null){
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("SEUS PRODUTOS DO CARRINHO:");
                foreach (Produto item in carrinho){
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine($"Jogo: {item.Name} || Preço: {item.Price.ToString("N2")} reais || Código: {item.Code}");
                }
                Console.ResetColor();
            }
        }

        // método que vai mostrar o valor final dos produtos que estão na lista do carrinho:
        public void MostrarValorFinal(){
            Console.ForegroundColor = ConsoleColor.Green;
            if(carrinho != null){
                foreach(Produto item in carrinho){
                    // forma extensa:
                    // FinalPrice = FinalPrice + item.Price;

                    // forma simplificada (o valores vão ir se somando):
                    FinalPrice += item.Price;
                }
                Console.WriteLine($"Total do carrinho: R${FinalPrice.ToString("N2")}");
                Console.ResetColor();
            }else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("O seu carrinho ainda está vazio!");
                Console.ResetColor();
            }
        }

        // método que vai alterar os produtos na lista do carrinho:
        public void AlterarProdutos(int codigo, Produto novoProduto){
            carrinho.Find(x => x.Code == codigo).Name = novoProduto.Name;
            carrinho.Find(x => x.Code == codigo).Price = novoProduto.Price;
        }
    }
}