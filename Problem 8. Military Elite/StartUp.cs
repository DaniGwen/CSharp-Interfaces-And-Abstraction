using System;
using System.Collections.Generic;

namespace Problem_8._Military_Elite
{
	class StartUp
	{
		static void Main()
		{
			var input = Console.ReadLine();
			SoldierFactory factory = new SoldierFactory();
			List<ISoldier> soldiers = factory.MakeSoldiers(input);
			Console.WriteLine();

			foreach (var mil in soldiers)
			{
				Console.WriteLine(mil.ToString());
			}

		}
	}
}
