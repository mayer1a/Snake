namespace Snake
{
    class VerticalLine : Figure
	{
		public VerticalLine(int yTop, int yBottom, int xCord, char symb)
		{
			for (int yCord = yTop; yCord <= yBottom; yCord++)
			{
				Point point = new(xCord, yCord, symb);
				PointsList.Add(point);
			}
		}
	}
}
