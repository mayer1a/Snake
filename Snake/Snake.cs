using System;
using System.Linq;

namespace Snake
{
    class Snake : Figure
	{
		private Direction Direction { get; }

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
    }
}
