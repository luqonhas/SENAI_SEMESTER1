using System;
using System.Collections.Generic;

namespace Project_Products
{
    public class Marca
    {
        public int Code { get; set; }
        public string BrandName { get; set; }
        public DateTime RegistrationDate { get; set; }

        List<Marca> ListaDeMarcas = new List<Marca>();
        public Marca Cadastrar(){
            Marca novaMarca = new Marca();

            Console.WriteLine("");
            Console.WriteLine("Digite o código da nova marca:");
            novaMarca.Code = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Digite o nome da nova marca:");
            novaMarca.BrandName = Console.ReadLine();

            novaMarca.RegistrationDate = DateTime.Now;

            ListaDeMarcas.Add(novaMarca);
            
            return novaMarca;
        }
        public void Listar(){
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (Marca item in ListaDeMarcas){
                Console.WriteLine($"Código: {item.Code} || Marca: {item.BrandName} || Data de Cadastro: {item.RegistrationDate}");
                
            }
            Console.ResetColor();
        }
        public void Deletar(int codigo){
            Marca marcaDeletar = ListaDeMarcas.Find(x => x.Code == codigo);
            ListaDeMarcas.Remove(marcaDeletar);
        }
    }
}