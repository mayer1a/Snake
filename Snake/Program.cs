using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 1;
            int y1 = 3;
            char symb1 = '*';

            DrawSymb(x1, y1, symb1);

            int x2 = 4;
            int y2 = 5;
            char symb2 = '#';

            DrawSymb(x2, y2, symb2);
        }

        static void DrawSymb(int x, int y, char symb)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symb);
        }
    }
}
