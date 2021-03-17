using System;

namespace Exercise_StudentRegistration.Class
{
    public class Aluno
    {
        public string nome;
        public string curso;
        public int idade;
        public string rg;
        public bool bolsista;
        public double media;
        public double mensalidade;

        public void VerMediaFinal(double mediaFinal){
            Console.WriteLine($"A média desse aluno é {mediaFinal}");
        }

        public void VerMensalidade(double mensalidade, bool temBolsa){
            if(temBolsa == true){
                Console.WriteLine("Esse É BOLSISTA!");
                Console.WriteLine($"Sua mensalidade sem desconto seria: {mensalidade} reais.");
                Console.WriteLine($"Sua mensalidade com desconto será: {0.7 * mensalidade} reais.");

            }else{
                Console.WriteLine("Esse NÃO É BOLSISTA, é um burguês safado!");
                Console.WriteLine($"Sua mensalidade sem desconto será: {mensalidade}");
            }


        }
    }
}