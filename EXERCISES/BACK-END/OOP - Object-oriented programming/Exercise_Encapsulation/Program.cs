using System;
using Exercise_Encapsulation.Class;

namespace Backend_AulaPOO_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            MasterCard cartao1 = new MasterCard();
            cartao1.ReceberNome("Lucas");

            cartao1.ExibirNome();
        }
    }
}
