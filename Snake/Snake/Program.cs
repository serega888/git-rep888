using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80,25);
            Walls walls = new Walls(80, 25);
            walls.Draw();


           HorisontalLine lowLine = new HorisontalLine(0,78,0,'+');
           lowLine.Drow();
           HorisontalLine upperLine = new HorisontalLine(0, 78, 24, '+');
           upperLine.Drow();
           VerticalLine leftLine = new VerticalLine(0,0,24,'+');
           leftLine.Drow();
           VerticalLine rightLine = new VerticalLine(78, 0,24, '+');
           rightLine.Drow();

           Point p1 = new Point(4, 4, '*');
           Snake snake = new Snake(p1, 4, Direction.RIGHT);
           snake.Drow();

           FoodCreator foodCreator = new FoodCreator(80,25,'$');
           Point food = foodCreator.CreateFood();
           food.Draw();
           while (true)
           {
               if (walls.IsHit(snake) || snake.IsHitTail())
               {
                   break;
               }
               if (snake.Eat(food))
               {
                   food = foodCreator.CreateFood();
                   food.Draw();
               }
               else
               {
                   snake.Move();
               }

               Thread.Sleep(100);

               if (Console.KeyAvailable)
               {
                   ConsoleKeyInfo key = Console.ReadKey();
                   snake.HandleKey(key.Key);
               }
               
           }
           
           
        }
    }
}
