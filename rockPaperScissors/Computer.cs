using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperScissors
{
    class Computer:Player
    {

        public Computer(string name)
        {
            this.name = name;
        }
        public override void ChooseGesture()
        {
            base.ChooseGesture();
            Random rnd = new Random();
            Player.pick = rnd.Next(0, 5);
        }

    }
}
