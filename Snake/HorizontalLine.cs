using System.Collections.Generic;

namespace Snake
{
	public class HorizontalLine
	{
		private List<Point> PointsList { get; }

		public HorizontalLine(int xLeft, int xRight, int yCord, char symb)
		{
			PointsList = new();

			for (int xCord = xLeft; xCord <= xRight; xCord++)
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