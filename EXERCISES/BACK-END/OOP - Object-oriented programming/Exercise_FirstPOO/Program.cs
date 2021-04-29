using System;
using System.Threading;

namespace Backend_PrimeiroPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Object instancing :
            Character player1 = new Character();
            player1.name = "luqonhas";
            player1.age = 17;
            player1.armor = "Golden Cap";
            player1.AI = "Amazing Skills";

            Character player2 = new Character();
            //Empty is the Bot

            Console.Clear();
            Console.WriteLine($"Match between: {player1.name} vs {player2.name}!");
            Console.WriteLine("");
            Thread.Sleep(3500);
            Console.WriteLine($"Details: {player1.name}' age {player1.age} || {player2.name}'s age {player2.age} \n\nArmor: {player1.name} with {player1.armor} || {player2.name} with {player2.armor} \n\nAI: {player1.name} with {player1.AI} || {player2.name} with {player2.AI}");
            
            Console.ForegroundColor = ConsoleColor.Red;
            Thread.Sleep(3000);
            Console.WriteLine("3");
            Thread.Sleep(1000);
            Console.WriteLine("2");
            Thread.Sleep(1000);
            Console.WriteLine("1");
            Thread.Sleep(800);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("FIGHT!!!!!!");

            Console.WriteLine($"The player {player1.name} has a priority to attack first because he's not a Bot.");
            Console.WriteLine($"{player1.name} can attack now!");
            int atk = int.Parse(Console.ReadLine());

            if(atk < 5){
                
            }
        }
    }
}
