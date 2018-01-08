using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAKE
{
    public class FoodManager
    {
        Random rand = new Random();
        Cell food = new Cell();
        public void foodspawn(int fx, int fy)
        {
            Console.SetCursorPosition(fx, fy);
            Console.Write("0");
            food.x = fx;
            food.y = fy;
        }
    }
}
