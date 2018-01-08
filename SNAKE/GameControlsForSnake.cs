using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAKE
{
    class GameControlsForSnake : GameControls
    {
        public override void Down(ref int dy, ref int dx)
        {
            dy = +1;
            dx = 0;
        }
        public override void Left(ref int dy, ref int dx)
        {
            dy = 0;
            dx = -1;
        }
        public override void Right(ref int dy, ref int dx)
        {
            dy = 0;
            dx = +1;
        }
        public override void Up(ref int dy, ref int dx)
        {
            dy = -1;
            dx = 0;
        }
    }
}
