using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperScissors
{
    class Computer:Player
    {
        int computerThrow;

        public Computer()
        {
            computerThrow = num.Next(1, 5);
        }
        Random num = new Random();
    }
}
