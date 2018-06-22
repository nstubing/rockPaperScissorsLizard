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
        public string[] gestureOptions;
        public string[,] gestureOutcomes;
        public int[] calculationOptions;

        //member constructor
        public Game()
        {
            player1 = new Human("Player One");
            gestureOptions=new string[] { "rock", "paper", "scissors", "spock", "lizard" };
            gestureOutcomes=new string [,] { { "", "", "crushes", "", "crushes" }, { "covers", "", "", "disproves", "" }, { "", "cuts", "", "", "decapitates" }, { "vaporizes", "", "disassembles", "", "" }, { "", "eats", "", "poisons", "" } };
            calculationOptions=new int[] { 4, 0, 1, 2, 3, 4, 0, 1 };
        }

        //member methods
        public void DisplayRules()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock! You may play against a computer or another human. The rules are simple, " + Environment.NewLine+
                "Rock crushes scissors and Rock squishes Lizard" + Environment.NewLine+
                "Paper covers Rock and Paper disproves Spock" + Environment.NewLine+
                "Scissors cuts Paper and Scissors cuts Lizard" + Environment.NewLine+
                "Lizard Eats Paper and Lizard poisons Spock" + Environment.NewLine+
                "Spock disassembles Scissors and Spock vaporizes Rock." + Environment.NewLine);
            Console.ForegroundColor = ConsoleColor.White;
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
        public void RunAllRounds()
        {
            for(int i=0;(player1.wins<2 && player2.wins<2);i++)
            {
                RunRound();
                FindWinner();
                DisplayCurrentScore();
            }
            DisplayGameWinner();
            Console.ReadLine();
        }


        public void RunRound()
        {
            player1.ChooseGesture();
            player2.ChooseGesture();
            if (player1.pick==player2.pick)
            {
                Console.WriteLine("Player One and Player Two both picked "+gestureOptions[player1.pick]+"!  You tied, try again!");
                RunRound();
            }
        }
        public void FindWinner()
        {

            if ((player2.pick==calculationOptions[player1.pick])||(player2.pick==calculationOptions[player1.pick+3]))
            {
                Console.WriteLine("Player one wins!  "+gestureOptions[player1.pick]+" "+gestureOutcomes[player1.pick,player2.pick]+" "+gestureOptions[player2.pick]+"!");
                player1.wins += 1;
            }
            else
            {
                Console.WriteLine("Player two wins!  " + gestureOptions[player2.pick] + " " + gestureOutcomes[player2.pick, player1.pick] + " " + gestureOptions[player1.pick]+"!");
                player2.wins += 1;
            }
        }
        public void DisplayCurrentScore()
        {
            Console.WriteLine("Current amount of wins.    Player One: " + player1.wins + "    Player Two: " + player2.wins);
        }
        public void DisplayGameWinner()
        {
            if(player1.wins==2)
            {
                Console.WriteLine("Player One is the winner of Rock, Paper, Scissors, Lizard, Spock with 2 wins against Player Two!");
            }
            else
            {
                Console.WriteLine("Player Two is the winner of Rock, Paper, Scissors, Lizard, Spock with 2 wins against Player One!");
            }
        }

        }
    }
