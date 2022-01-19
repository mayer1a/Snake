using System.Collections.Generic;

namespace Snake
{
	class Walls
	{
		internal List<Figure> WallList { get; }

		internal int Width { get; }
		internal int Height { get; }

		public Walls(int mapWidth, int mapHeight)
		{
			WallList = new List<Figure>();

			HorizontalLine horizontalLineTop = new(0, mapWidth - 2, 0, '•');
			HorizontalLine horizontalLineBottom = new(0, mapWidth - 2, mapHeight - 1, '•');
			VerticalLine verticalLineLeft = new(0, mapHeight - 1, 0, '•');
			VerticalLine verticalLineRight = new(0, mapHeight - 1, mapWidth - 2, '•');

			WallList.Add(horizontalLineTop);
			WallList.Add(horizontalLineBottom);
			WallList.Add(verticalLineLeft);
			WallList.Add(verticalLineRight);
		}

		internal bool IsHit(Figure figure)
		{
			foreach (var wall in WallList)
			{
				if (wall.IsHit(figure))
				{
					return true;
				}
			}
			return false;
		}

		internal void Draw()
		{
			foreach (var wall in WallList)
			{
				wall.Draw();
			}
		}
	}
}
