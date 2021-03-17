namespace Backend_PrimeiroPOO
{
    public class Character
    {
        public string name = "Bot";
        public int age = 0;
        public string armor = "Clothes";
        public string AI = "Brain";
        public int life = 100;

        public int attack1(){
            return 20;
        }

        public int attack2(){
            return 50;
        }
        
        public int defense(int attack){
            this.life = this.life - attack;

            return this.life = this.life - attack;
        }

    }
}