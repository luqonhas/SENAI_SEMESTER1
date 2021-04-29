using System;

namespace Exercise_Abstraction.Class
{
    public class Pagamento
    {
        
        protected DateTime data;
        public DateTime Data{
            get;set;
        }
        protected float valor;
        public bool Cancelar(string resposta){
            if(resposta == "s"){
                return true;
            }
            return false;
        }
        public void ReceberValor(float valorRecebido){
            this.valor = valorRecebido;
        }
        public void ExibirValor(){
            Console.WriteLine("Seu valor a pagar é: "+this.valor);
        }
        
    }
}