using System;

namespace ConsoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0,index;
            while (true)
            {
                if (Console.ReadKey().Key == ConsoleKey.RightArrow) x++;
                if (Console.ReadKey().Key == ConsoleKey.LeftArrow)  x--;
                if (Console.ReadKey().Key == ConsoleKey.UpArrow)  y--;
                if (Console.ReadKey().Key == ConsoleKey.DownArrow)  y++;
                Console.Clear();
                for (index=1; index<= y;index++) Console.WriteLine();
                for (index=1;index<=x;index++) Console.Write("  ");
                Console.Write("<");
            }
        }
    }
}
