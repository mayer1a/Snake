using System;
namespace Snake
{
    public class Point
    {
        public int CordX { get; set; }
        public int CordY { get; set; }
        public char Symb { get; init; }

        public Point(int cordX, int cordY, char symb)
        {
            CordX = cordX;
            CordY = cordY;
            Symb = symb;
        }

        
        public void Draw ()
        {
            Console.SetCursorPosition(CordX, CordY);
            Console.Write(Symb);
        }
    }
}
