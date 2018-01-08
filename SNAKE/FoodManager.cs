using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAKE
{
    class FoodManager
    {
        Random rand = new Random();
        public void foodspawn()
        {
            Cell food = new Cell
            {
                x = rand.Next(2, Console.WindowWidth),
                y = rand.Next(2, Console.WindowHeight)
            };
            Console.SetCursorPosition(food.x, food.y);
            Console.Write("0");
        }
        
    }
}
