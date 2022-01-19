using System;
using System.Collections.Generic;

namespace Snake
{
	class HorizontalLine : Figure
	{
		public HorizontalLine(int xLeft, int xRight, int yCord, char symb)
		{
			PointsList = new List<Point>();

			for (int xCord = xLeft; xCord <= xRight; xCord++)
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