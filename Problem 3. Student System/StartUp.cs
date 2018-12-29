using System;

namespace Hotel_Reservation
{
	class StartUp
	{
		static void Main()
		{
			var input = Console.ReadLine();

			PriceCalculator calculator = new PriceCalculator(input);
		}
	}
}
