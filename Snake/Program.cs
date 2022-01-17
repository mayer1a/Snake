﻿using System.Threading;

namespace Snake
{
    class Program
	{
		static void Main(string[] args)
		{
			//Point point2 = new(3, 4, '#');

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
			snake.Move();
			Thread.Sleep(300);
			snake.Move();
			Thread.Sleep(300);
			snake.Move();
			Thread.Sleep(300);
			snake.Move();
			Thread.Sleep(300);
			snake.Move();
			Thread.Sleep(300);
			snake.Move();
			Thread.Sleep(300);
			snake.Move();
			Thread.Sleep(300);
			snake.Move();
			Thread.Sleep(300);
		}
	}
}
