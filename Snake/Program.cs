using System;
using System.Threading;

namespace Snake
{
	class Program
	{
		static void Main(string[] args)
		{
			// Отрисовка рамки игрового поля
			Walls walls = new(80, 35);
			walls.Draw();

			// Отрисовка змейки
			Point startPoint = new(10, 10, '*');
			Snake snake = new(startPoint, length: 4, Direction.RIGHT);
			snake.Draw();

			FoodCreator foodCreator = new(80, 35, '+');
			Point food = foodCreator.CreateFood();
			food.DrawObject();

			while (snake.IsPlaying)
			{
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }

                if (snake.Eat(food))
				{
					food = foodCreator.CreateFood();
					food.DrawObject();
				}
				else
				{
					snake.Move();
				}

				Thread.Sleep(300);

				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo keyInfo = Console.ReadKey();
					snake.HandleKey(keyInfo.Key);
				}

				snake.Move();
			}

			Console.Clear();

		}
	}
}
