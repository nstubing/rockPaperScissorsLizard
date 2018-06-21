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
            if (Console.ReadLine() == "yes")
            {
                player2 = new Human("Player Two");
            }
            else if (Console.ReadLine() == "no")
            {
                player2 = new Computer();
            }
            else
            {
                Console.WriteLine("Please enter a valid option only!");
                GetPlayerTwo();
            }
        }


        public void RunRound()
        {
            player1.ChooseGesture();
            player2.ChooseGesture();
        }

    }
}
