using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAKE
{
    struct Cell
    {
        public int x, y;
    }

    abstract class SnakeGame
    {
        protected Cell[] snake;
        protected static int countSnake = 3;
        protected ConsoleKeyInfo key = new ConsoleKeyInfo();

        public SnakeGame(int count)
        {
            snake = new Cell[count];
        }

        public void Create()
        {
            Cell[] cell = new Cell[100];
            snake[0].x = Console.WindowWidth/2;
            snake[0].y = Console.WindowHeight/2;
            snake[1].x = (Console.WindowWidth/2)-1;
            snake[1].y = Console.WindowHeight/2;
            snake[2].x = (Console.WindowWidth/2)-2;
            snake[2].y = Console.WindowHeight/2;
        }

    }
}
