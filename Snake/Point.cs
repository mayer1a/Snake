using System;

namespace Snake
{
	class Point
	{
		public int XCord { get; set; }
		public int YCord { get; set; }
		public char Symb { get; set; }

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

		public void DrawObject()
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
					YCord -= offset;
					break;
				case Direction.DOWN:
					YCord += offset;
					break;
                default:
                    break;
            }
        }

        internal void Clear()
        {
            Symb = ' ';
			DrawObject();
        }

        public override string ToString()
        {
            return XCord + ", " + YCord + ", " + Symb;
        }

		internal bool IsHit(Point point)
        {
			return point.XCord == XCord && point.YCord == YCord;
        }
    }
}
