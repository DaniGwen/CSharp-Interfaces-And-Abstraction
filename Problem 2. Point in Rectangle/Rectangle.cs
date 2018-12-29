using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_2._Point_in_Rectangle
{
	public class Rectangle
	{
		private Square Square;
		private Point Point;

		public Rectangle() { }

		public Rectangle(Square square, Point point) : this()
		{
			this.Square = square;
			this.Point = point;
		}

		public bool Contains()
		{
			bool isInside = true;
			Point point = this.Point;

			if (point.X < Square.TopLeft.X || point.Y < Square.TopLeft.Y || point.X > Square.BottomRight.X || point.Y > Square.BottomRight.Y)
			{
				isInside = false;
			}

			return isInside;
		}
	}
}
