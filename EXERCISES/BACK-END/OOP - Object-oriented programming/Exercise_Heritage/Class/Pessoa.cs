using System;

namespace Exercise_Heritage.Class
{
    public class Pessoa
    {
        public string nome;
        public int idade;
        public string DarBoasVindas(string nomeUsuario){
            return "Olá " + nomeUsuario +"! Seja bem vindo(a)!";
        }
    }
}