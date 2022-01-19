using System;

namespace Snake
{
	class FoodCreator
	{
		public int MapWidth { get; }
		public int MapHeight { get; }
		public char Symb { get; }

        Random random = new();

		public FoodCreator(int mapWidth, int mapHeight, char symb)
		{
			MapWidth = mapWidth;
			MapHeight = mapHeight;
			Symb = symb;
		}

		public Point CreateFood()
        {
			int xCord = random.Next(2, MapWidth - 2);
			int yCord = random.Next(2, MapHeight - 2);
			return new Point(xCord, yCord, Symb); 
        }
	}
}
