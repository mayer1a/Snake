using System.Collections.Generic;

namespace Snake
{
	public class VerticalLine
	{
		private List<Point> PointsList { get; }

		public VerticalLine(int yTop, int yBottom, int xCord, char symb)
		{
			PointsList = new();

			for (int yCord = yTop; yCord <= yBottom; yCord++)
			{
				Point point = new(xCord, yCord, symb);
				PointsList.Add(point);
			}
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
