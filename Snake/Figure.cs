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

		public void DrawLines()
		{
			foreach (Point p in PointsList)
			{
				p.Draw();
			}
		}
	}
}
