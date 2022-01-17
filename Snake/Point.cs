using System;

namespace Snake
{
	class Point
	{
		private int XCord { get; set; }
		private int YCord { get; set; }
		private char Symb { get; set; }

		public Point(int xCord, int yCord, char symb)
		{
			XCord = xCord;
			YCord = yCord;
			Symb = symb;
		}

		public Point(Point point)
        {
			XCord = point.XCord;
			YCord = point.YCord;
			Symb = point.Symb;
        }

		public void Draw()
		{
			Console.SetCursorPosition(XCord, YCord);
			Console.Write(Symb);
		}

        public void Move(int offset, Direction direction)
        {
            switch (direction)
            {
				case Direction.LEFT:
					XCord -= offset;
					break;
				case Direction.RIGHT:
					XCord += offset;
					break;
				case Direction.UP:
					YCord += offset;
					break;
				case Direction.DOWN:
					YCord -= offset;
					break;
                default:
                    break;
            }
        }

        internal void Clear()
        {
            Symb = ' ';
			Draw();
        }

        public override string ToString()
        {
            return XCord + ", " + YCord + ", " + Symb;
        }
    }
}
