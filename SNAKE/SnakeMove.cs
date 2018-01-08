using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SNAKE
{
    class Move : SnakeGame
    {
        GameControls gameControls;
        public Move(int count) : base(count)
        {
            gameControls = new GameControlsForSnake();
        }
        private int dx = 1, dy = 0;
        public void Moving()
        {
            while (true)
            {
                for (int i = 0; i < countSnake; i++)
                {
                    Console.SetCursorPosition(snake[i].x, snake[i].y);
                    Console.WriteLine("*");
                }
                Thread.Sleep(200);
                Console.SetCursorPosition(snake[countSnake - 1].x, snake[countSnake - 1].y);
                Console.WriteLine(" ");
                for (int i = countSnake - 1; i > 0; i--)
                {
                    snake[i] = snake[i - 1];
                }
                snake[0].x += dx;
                snake[0].y += dy;
                if (Console.KeyAvailable)
                {
                    key = Console.ReadKey();
                    switch (key.Key)
                    {
                        case ConsoleKey.UpArrow:
                            gameControls.Up(ref dy, ref dx);
                            break;
                        case ConsoleKey.DownArrow:
                            gameControls.Down(ref dy, ref dx);
                            break;
                        case ConsoleKey.LeftArrow:
                            gameControls.Left(ref dy, ref dx);
                            break;
                        case ConsoleKey.RightArrow:
                            gameControls.Right(ref dy, ref dx);
                            break;
                    }
                }
            }
        }
    }
}
