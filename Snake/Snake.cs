using System;
using System.Collections.Generic;
using System.Linq;

namespace Snake
{
    class Snake : Figure
	{
		private Direction Direction { get; set; }
		internal bool IsPlaying { get; set; } = true;

		public Snake(Point tail, int length, Direction direction)
		{
			PointsList = new List<Point>();
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
			head.DrawObject();
        }

        internal bool IsHitTail()
        {
			var head = PointsList.Last();

            for (int i = 0; i < PointsList.Count - 1; i++)
            {
                if (head.IsHit(PointsList[i]))
                {
					return true;
                }
            }

			return false;
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
				case ConsoleKey.Escape:
					IsPlaying = false;
					break;
				default:
					break;
			}
		}

		internal bool Eat(Point food)
        {
			Point head = GetNextPoint();

			if(head.IsHit(food))
            {
				food.Symb = head.Symb;
				PointsList.Add(food);
				return true;
            }
			else
            {
				return false;
            }
        }
    }
}
