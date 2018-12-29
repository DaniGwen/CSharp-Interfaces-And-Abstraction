using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_2._Point_in_Rectangle
{
	public class Square
	{
		public Point TopLeft;
		public Point BottomRight;

		public Square(Point topLeft, Point bottomRight)
		{
			this.TopLeft = topLeft;
			this.BottomRight = bottomRight;
		}
	}
}
