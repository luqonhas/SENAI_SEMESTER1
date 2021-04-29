using System;
using System.Threading;
using Exercise_PolymorphismOverload.Class;

namespace Exercise_PolymorphismOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Funcionario func = new Funcionario();
            func.Mostrar();
            Console.WriteLine("");
            func.Mostrar("Lucas");
            Console.WriteLine("");
            func.Mostrar(1);
        }
    }
}
