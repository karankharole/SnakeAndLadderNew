using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderNew
{
    internal class SnakeAndLadder
    {

        public void firstDiceRoll()
        {
            Console.Write("First dice roll : ");
            Random random = new Random();
            Console.WriteLine(random.Next(1, 6));
        }
    }
}
