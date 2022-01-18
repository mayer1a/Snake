using System;
using System.Threading;

namespace Snake
{
    class Program
	{
		static void Main(string[] args)
		{
			// Отрисовка рамки игрового поля 
			HorizontalLine horizontalLineTop = new(0, 78, 0, '•');
			HorizontalLine horizontalLineBottom = new(0, 78, 36, '•');
			VerticalLine verticalLineLeft = new(0, 36, 0, '•');
			VerticalLine verticalLineRight = new(0, 36, 78, '•');

			horizontalLineTop.DrawLines();
			horizontalLineBottom.DrawLines();
			verticalLineLeft.DrawLines();
			verticalLineRight.DrawLines();

			// Отрисовка змейки
			Point startPoint = new(4, 5, '*');
			Snake snake = new(startPoint, length: 4, Direction.RIGHT);
			snake.DrawLines();

			while (true)
            {
				if (Console.KeyAvailable)
                {
					ConsoleKeyInfo keyInfo = Console.ReadKey();
					snake.HandleKey(keyInfo.Key);
                }

				Thread.Sleep(100);
				snake.Move();
            }
		}
	}
}
