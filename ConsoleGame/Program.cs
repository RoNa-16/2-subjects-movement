using System;

namespace ConsoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int x2 = 0, y2 = 0;
            int x = 0, y = 0;
            while (true)
            {
                var key = Console.ReadKey();

                Console.Clear();

                if (key.Key == ConsoleKey.RightArrow) x++;
                if (key.Key == ConsoleKey.LeftArrow)  x--;
                if (key.Key == ConsoleKey.UpArrow)  y--;
                if (key.Key == ConsoleKey.DownArrow)  y++;

                if (key.Key == ConsoleKey.D) x2++;
                if (key.Key == ConsoleKey.A) x2--;
                if (key.Key == ConsoleKey.W) y2--;
                if (key.Key == ConsoleKey.S) y2++;

                Console.WriteLine("player1 ({0}, {1})");
                Console.WriteLine("player2 ({0}, {1})", x2 ,y2);
                renderer(x, y, x2, y2);
            }
        }
        public static void renderer(int x, int y, int x2, int y2)
        {
            int index;

            if (y2 < y)
            {
                for (index = 1; index <= y2; index++) Console.WriteLine();
                for (index = 1; index <= x2; index++) Console.Write("  "); Console.Write("22");
                for (index = 1; index <= y - y2; index++) Console.WriteLine();
                for (index = 1; index <= x; index++) Console.Write("  "); Console.Write("11");
            }
            if (y < y2)
            {
                for (index = 1; index <= y; index++) Console.WriteLine();
                for (index = 1; index <= x; index++) Console.Write("  "); Console.Write("11");
                for (index = 1; index <= y2 - y; index++) Console.WriteLine();
                for (index = 1; index <= x2; index++) Console.Write("  "); Console.Write("22");
            }
            if (y == y2)
            {
                if (x < x2)
                {
                    for (index = 1; index <= y; index++) Console.WriteLine();
                    for (index = 1; index <= x; index++) Console.Write("  "); Console.Write("11");
                    for (index = 1; index <= x2 - x - 1; index++) Console.Write("  "); Console.Write("22");
                }
                if (x2 < x)
                {
                    for (index = 1; index <= y; index++) Console.WriteLine();
                    for (index = 1; index <= x2; index++) Console.Write("  "); Console.Write("22");
                    for (index = 1; index <= x - x2 - 1; index++) Console.Write("  "); Console.Write("11");
                }
                if (x == x2)
                {
                    Console.Beep(50, 300);
                }
            }
        }
    }
}
