using System;
using Exercise_Console.Controller;
using Exercise_Console.Models;
using Exercise_Console.View;

namespace Exercise_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            UserController user = new UserController();
            user.Cadastrar();
            user.Listar();
            ProductController product = new ProductController();
            product.Cadastrar();
            product.Listar();
        }
    }
}
