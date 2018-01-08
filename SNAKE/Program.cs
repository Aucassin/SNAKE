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
            Random rand = new Random();
            FoodManager food = new FoodManager();
            food.foodspawn(rand.Next(0, Console.WindowWidth), rand.Next(0, Console.WindowHeight));

            Move start = new Move(100);
            start.Create();
            start.Moving();
        }
    }
}
