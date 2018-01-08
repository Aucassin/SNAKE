using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAKE
{
    abstract class GameControls
    {
        public abstract void Up(ref int y, ref int x);
        public abstract void Down(ref int y, ref int x);
        public abstract void Left(ref int y, ref int x);
        public abstract void Right(ref int y, ref int x);
    }
}
