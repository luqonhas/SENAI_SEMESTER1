using System;

namespace CalculandoMedia_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string situacao = "";

            Console.Write("Digite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());
            
            double media = (nota1 + nota2) / 2;


            if(media >= 7){
                situacao = " aprovado";
            }
            else{
                situacao = " reprovado";
            }

            Console.WriteLine("O aluno foi" + situacao + " e, sua média final é " + media + "!");
        }
    }
}
