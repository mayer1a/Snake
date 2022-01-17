using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> charsList = new();

            charsList.Add('*');
            charsList.Add('#');
            charsList.Add('&');
            charsList.Add('@');

            Point point1 = new(1, 3, charsList[0]);
            Point point2 = new(3, 4, charsList[1]);
            Point point3 = new(3, 7, charsList[2]);
            Point point4 = new(4, 6, charsList[3]);

            List<Point> pointsList = new();
            
            pointsList.Add(point1);
            pointsList.Add(point2);
            pointsList.Add(point3);
            pointsList.Add(point4);

            point1.Draw();
            point2.Draw();
            point3.Draw();
            point4.Draw();

        }
    }
}
