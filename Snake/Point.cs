using System;

namespace Snake
{
	public class Point
	{
		public int XCord { get; set; }
		public int YCord { get; set; }
		public char Symb { get; init; }

		public Point(int xCord, int yCord, char symb)
		{
			XCord = xCord;
			YCord = yCord;
			Symb = symb;
		}

		public void Draw()
		{
			Console.SetCursorPosition(XCord, YCord);
			Console.Write(Symb);
		}
	}
}
