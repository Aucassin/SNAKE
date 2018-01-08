using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAKE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            FoodManager food = new FoodManager();
            food.foodspawn();
            Move start = new Move(100);
            start.Create();
            start.Moving();
        }
    }
}
