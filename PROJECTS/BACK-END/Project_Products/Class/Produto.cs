using System;
using System.Collections.Generic;

namespace Project_Products.Class
{
    public class Produto
    {
        public int Code { get; set; }
        public string ProductName { get; set; }
        public float Price { get; set; }
        public DateTime RegistrationDate { get; set; }
        public Marca Brand = new Marca();
        public Usuario RegistratedBy = new Usuario();
        
        List<Produto> ListaDeProdutos = new List<Produto>();
        
        public void Cadastrar(){
            Produto novoProduto = new Produto();

            Console.WriteLine("");
            Console.WriteLine("Digite o código do novo produto:");
            novoProduto.Code = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Digite o nome do novo produto:");
            novoProduto.ProductName = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("Digite o preço do novo produto:");
            novoProduto.Price = float.Parse(Console.ReadLine());

            novoProduto.Brand = Brand.Cadastrar();

            novoProduto.RegistrationDate = DateTime.Now;

            ListaDeProdutos.Add(novoProduto);
        }
        public void Listar(){
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (Produto item in ListaDeProdutos){
                Console.WriteLine($"Código: {item.Code} || Nome: {item.ProductName} || Preço: {item.Price} || Marca: {item.Brand.BrandName}");
                Console.WriteLine($"Data e hora do cadastro: {item.RegistrationDate}");
                Console.WriteLine($"Cadastrado por: {item.RegistratedBy}");
                Console.ResetColor();
            }
        }
        public void Deletar(int codigo){
            Produto produtoDeletar = ListaDeProdutos.Find(x => x.Code == codigo);
            ListaDeProdutos.Remove(produtoDeletar);
        }
    }
}