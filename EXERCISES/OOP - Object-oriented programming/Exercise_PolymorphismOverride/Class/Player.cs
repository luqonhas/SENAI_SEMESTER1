using System;

namespace Exercise_PolymorphismOverride.Class
{
    public abstract class Player
    {
        private float velocidade;

        private float forcaPulo;

        public virtual void Correr(){
            Console.WriteLine("Velocidade padrão de 50x");
        }

        public virtual string Pular(){
            return "";
        }
        
    }
}