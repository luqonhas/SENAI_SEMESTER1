using System;

namespace Exercise_PolymorphismOverload.Class
{
    public class Funcionario
    {
        public string[] lista = {"Lucas", "Paulo"};
        public void Mostrar(){
            foreach(var item in lista){
                Console.WriteLine(item);
            }
        }
        public void Mostrar(int indice){
            Console.WriteLine($"Busca por índice: {lista[indice]}");
        }
        public void Mostrar(string busca){
            foreach(var item in lista){
                if(item == busca){
                    Console.WriteLine($"Resutados da busca: {item}");
                }
            }
        }
    }
}