using System;
namespace Snake
{
    public class Point
    {
        public int cordX;
        public int cordY;
        public char symb;

        public Point(int cordX, int cordY, char symb)
        {
            this.cordX = cordX;
            this.cordY = cordY;
            this.symb = symb;
        }

        public void Draw ()
        {
            Console.SetCursorPosition(cordX, cordY);
            Console.Write(symb);
        }
    }
}
