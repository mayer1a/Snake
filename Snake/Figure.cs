using System;
using System.Collections.Generic;

namespace Snake
{
    class Figure
	{
        protected List<Point> PointsList;

		public Figure()
		{
		}

        public virtual void Draw()
		{
			foreach (Point point in PointsList)
			{
				point.DrawObject();
			}
		}

		internal bool IsHit(Figure figure)
        {
            foreach (var point in PointsList)
            {
                if (figure.IsHit(point))
                {
					return true;
                }
            }

			return false;
        }

		private bool IsHit(Point point)
        {
            foreach (var p in PointsList)
            {
                if (p.IsHit(point))
                {
                    return true;
                }
            }

            return false;
        }
	}
}
