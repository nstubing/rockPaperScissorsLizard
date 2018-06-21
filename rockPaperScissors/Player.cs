﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperScissors
{
    class Player
    {
        //member variable
        public string name;
        public int pick;

        //constructor
        public Player()
        {

        }
        //member methods
        public virtual void ChooseGesture()
        {
            // choose gesture
            Console.WriteLine("Choose a gesture! Write 'rock', 'paper', 'scissors', 'lizard', or 'spock'." );
            switch(Console.ReadLine().ToLower().Trim())
            {
                case "rock":
                    pick = 0;
                    break;
                case "paper":
                    pick = 1;
                    break;
                case "scissors":
                    pick = 2;
                    break;
                case "lizard":
                    pick = 3;
                    break;
                case "spock":
                    pick = 4;
                    break;
                default:
                    Console.WriteLine("Please enter a valid input!");
                    ChooseGesture();
                    break;
            }


        }
    }
}
