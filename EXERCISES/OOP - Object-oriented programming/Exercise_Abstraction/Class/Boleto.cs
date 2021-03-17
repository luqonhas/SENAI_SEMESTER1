using System;

namespace Exercise_Abstraction.Class
{
    public class Boleto:Pagamento
    {
        private int codigoDeBarras;
        private double valorFinalBoleto;
        private double valorMultiplicadoBoleto;
        private double porcentagemBoleto = 0.12;
        private float valorDoBoleto = 500;
     
        public void RegistrarCodigoDeBarras(){
            Random randomico = new Random();
            this.codigoDeBarras = randomico.Next();
            Console.WriteLine("O seu código de barras é: "+codigoDeBarras.ToString("N0"));
        }
        public string Desconto(double valorRecebido){
            valorMultiplicadoBoleto = valorRecebido * porcentagemBoleto;
            valorFinalBoleto = valorRecebido - valorMultiplicadoBoleto;
            
            return "Valor que seria pago SEM o desconto do boleto: "+valorRecebido.ToString("N2")+" reais.\nValor pago COM o desconto do boleto: "+valorFinalBoleto.ToString("N2")+" reais.";
        }
        public void GerarBoleto(){
            Data = DateTime.Today;
            Console.WriteLine($"Valor do boleto: {this.valorDoBoleto} reais.");
            Console.WriteLine("");
            Console.WriteLine("Sua data de validade é: "+Data.AddDays(10));
            Console.WriteLine("");
        }
        
    }
}