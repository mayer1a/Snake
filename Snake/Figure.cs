using System.Collections.Generic;

namespace Snake
{
    class Figure
	{
		protected List<Point> PointsList { get; }

		public Figure()
		{
			PointsList = new();
		}

        public virtual void DrawObject()
		{
			foreach (Point p in PointsList)
			{
				p.Draw();
			}
		}
	}
}
