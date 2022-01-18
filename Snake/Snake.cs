using System;
using System.Linq;

namespace Snake
{
    class Snake : Figure
	{
		private Direction Direction { get; set; }

		public Snake(Point tail, int length, Direction direction)
		{
			Direction = direction;

			for(int point = 0; point < length; point++)
            {
				Point bodyPoint = new(tail);
				bodyPoint.Move(point, Direction);
				PointsList.Add(bodyPoint);
            }
		}

        internal void Move()
        {
			Point tail = PointsList.First();
			PointsList.Remove(tail);
			Point head = GetNextPoint();
			PointsList.Add(head);

			tail.Clear();
			head.Draw();
        }

        private Point GetNextPoint()
        {
			Point head = PointsList.Last();
			Point nextPoint = new(head);
			nextPoint.Move(1, Direction);

			return nextPoint;
        }

		internal void HandleKey (ConsoleKey consoleKey)
        {
            switch (consoleKey)
			{
				case ConsoleKey.LeftArrow or ConsoleKey.A:
					Direction = Direction.LEFT;
					break;
				case ConsoleKey.RightArrow or ConsoleKey.D:
					Direction = Direction.RIGHT;
					break;
				case ConsoleKey.UpArrow or ConsoleKey.W:
					Direction = Direction.UP;
					break;
				case ConsoleKey.DownArrow or ConsoleKey.S:
					Direction = Direction.DOWN;
					break;
				default:
					break;
			}
		}
    }
}
