namespace Snake
{
    class Program
	{
		static void Main(string[] args)
		{
			//Point point1 = new(1, 3, '*');
			//Point point2 = new(3, 4, '#');

			//point1.Draw();
			//point2.Draw();

			HorizontalLine horizontalLineTop = new(2, 20, 1, '-');
			HorizontalLine horizontalLineBottom = new(2, 20, 20, '-');
			VerticalLine verticalLineLeft = new(1, 18, 1, '|');
			VerticalLine verticalLineRight = new(1, 18, 20, '|');

			horizontalLineTop.DrawLines();
			horizontalLineBottom.DrawLines();
			verticalLineLeft.DrawLines();
			verticalLineRight.DrawLines();
		}
	}
}
