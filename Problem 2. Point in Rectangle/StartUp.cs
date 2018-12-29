using System;
using System.Linq;

namespace Problem_2._Point_in_Rectangle
{
	class StartUp
	{
		static void Main(string[] args)
		{
			var argsRectangle = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();
			int n = int.Parse(Console.ReadLine());

			Point pointToCheck = new Point();
			Point pointTopLeft = new Point();
			Point pointBottomRight = new Point();
			pointTopLeft.X = argsRectangle[0];
			pointTopLeft.Y = argsRectangle[1];
			pointBottomRight.X = argsRectangle[2];
			pointBottomRight.Y = argsRectangle[3];

			Square square = new Square(pointTopLeft,pointBottomRight);
			Rectangle rectangle;

			for (int i = 0; i < n; i++)
			{
				var pointArgs = Console.ReadLine()
					.Split(" ")
					.Select(int.Parse)
					.ToArray();

				pointToCheck.X = pointArgs[0];
				pointToCheck.Y = pointArgs[1];

				rectangle = new Rectangle(square, pointToCheck);
				Console.WriteLine(rectangle.Contains());
			}
		}
	}
}
