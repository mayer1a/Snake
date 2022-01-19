using System;
using System.Collections.Generic;

namespace Snake
{
	class VerticalLine : Figure
	{
		public VerticalLine(int yTop, int yBottom, int xCord, char symb)
		{
			PointsList = new List<Point>();

			for (int yCord = yTop; yCord <= yBottom; yCord++)
			{
				Point point = new(xCord, yCord, symb);
				PointsList.Add(point);
			}
		}

		public override void Draw()
		{
			Console.ForegroundColor = ConsoleColor.Green;

			base.Draw();

			Console.ForegroundColor = ConsoleColor.White;
		}
	}
}
