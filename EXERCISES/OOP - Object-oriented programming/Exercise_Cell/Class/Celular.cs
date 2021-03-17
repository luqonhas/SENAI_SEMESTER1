using System;

namespace Exercise_Cell.Class
{
    public class Celular
    {
        public string cor = "Preto";
        public string modelo = "Motorola One Action";
        public string tamanho = "15cm";
        public bool ligado = false;
        public string contato = "Lucas";

        public void Ligar(){
            this.ligado = true;
            Console.WriteLine("O celular está ligado! Pode mexer!");
        }

        public void Desligar(){
            this.ligado = false;
            Console.WriteLine("O celular está desligado! Ligue-o para poder mexer.");
        }


        public void FazerLigação(){
            Console.Write("Discando...Ligando...");
        }

        public void EnviarMensagem(string contato){
            Console.WriteLine($"Enviando mensagem para {contato}");
        }
    }
}