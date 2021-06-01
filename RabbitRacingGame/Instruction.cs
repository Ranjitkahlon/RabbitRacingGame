using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitRacingGame
{
   public class Instruction
    {
        public String Name { get; set; }
        public int rabit { get; set; }
        public int bet { get; set; }

        public int budget { get; set; }
        public int winner { get; set; }

        public int working() {
            if (rabit == winner)
            {
                return budget + bet;
            }
            else {
                return budget - bet;
            }
        }

        public int Jump() {
            Random rd = new Random();
            return rd.Next(1, 50);
        }
    }
}
