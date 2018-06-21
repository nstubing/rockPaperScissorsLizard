using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperScissors
{
    class Game
    {
        //member variable
        //string inputOne;
        //string inputTwo;
        Player player1;
        Player player2;
        //member constructor
        public Game()
        {
            player1 = new Human("Player One");
        }

        //member methods
        public void DisplayRules()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock! You may play against a computer or another human. The rules are simple, " +
                "Rock crushes scissors and Rock squishes Lizard"+
                "Paper covers Rock and Paper disproves Spock" +
                "Scissors cuts Paper and Scissors cuts Lizard" +
                "Lizard Eats Paper and Lizard poisons Spock" +
                "Spock disassembles Scissors and Spock vaporizes Rock.");
        }
        public void GetPlayerTwo()
        {
            
            Console.WriteLine("Are you playing with another player? Type 'yes' or 'no'. If you have no friends you will play against a computer :(");
            switch(Console.ReadLine().ToLower().Trim())
            {
                case "yes":
                    player2 = new Human("Player Two");
                    break;
                case "no":
                    player2 = new Computer("Computer");
                    break;
                default:
                    Console.WriteLine("Please enter a valid option only!");
                    GetPlayerTwo();
                    break;
            }
        }


        public void RunRound()
        {
            player1.ChooseGesture();
            player2.ChooseGesture();
        }
       // public void DeclareWinner()
       // {
         //   public int a = int Player.player1.pick;
           // public int b = player2.pick;
        //}

    }
}
