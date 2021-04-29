using System;

namespace Exercise_Encapsulation.Class
{
    public class Cartao
    {
        private string nome;
        private string numero;
        private string bandeira;
        protected string token = "qwertyui";
        private string cvv;
        protected float limite = 5000;
        
        public string RegistrarCompra(bool validado){
            return "";
        }
        private bool ValidarCompra(float saldo){
            return true;
        }
        protected string ValidarToken(string token){
            return "";
        }
        public void ExibirNome(){
            Console.WriteLine($"O seu nome é {this.nome}");
        }
        public void ReceberNome(string nomeRecebido){
            this.nome = nomeRecebido;
        }
    }
}