using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Two
{
    

    class Game
    {
        public void Fight()
        { //Making an array from custom classes. Interface parent converts them to same data type.         
            var choices = new IPlayer[]{
                new PlayerPaper(),
                new PlayerRock(),
                new PlayerScissors()
            }; 

            var p = new Random();

            //Setting Player One and Player Two to random choices.
            var Player1 = choices[p.Next(3)].Act(); 
            var Player2 = choices[p.Next(3)].Act();

            //Conditions for victory
            if (Player1 == "rock" && Player2 == "scissors")
            {
                Console.WriteLine("Player 1 wins!");
            }
            else if (Player1 == "rock" && Player2 == "paper")
            {
                Console.WriteLine("Player 2 wins!");
            }
            else if (Player1 == "scissors" && Player2 == "paper")
            {
                Console.WriteLine("Player 1 wins!");
            }
            else if (Player1 == "scissors" && Player2 == "rock")
            {
                Console.WriteLine("Player 2 wins!");
            }
            else if (Player1 == "paper" && Player2 == "rock")
            {
                Console.WriteLine("Player 1 wins!");
            }
            else if (Player1 == "paper" && Player2 == "scissors")
            {
                Console.WriteLine("Player 2 wins!");
            }
            else
            {
                Console.WriteLine("It's a tie :(");
            }

            Console.ReadLine();
           
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // () Instantiates the Game class so Fight method can be called.
            var result = new Game(); 

            result.Fight();

        }
    }
}
