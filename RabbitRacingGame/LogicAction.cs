using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitRacingGame
{
    class LogicAction
    {
        public int chk(int y) {
            if (y % 2 != 0)
            {
                return 1;
            }
            else {
                return 2;
            }
        }
    }
}
