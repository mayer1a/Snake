using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new(1, 3, '*');
            Point point2 = new(3, 4, '#');

            point1.Draw();
            point2.Draw();
        }
    }
}
