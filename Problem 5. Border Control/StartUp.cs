using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_5._Border_Control
{
	class StartUp
	{
		static void Main()
		{
			List<ICitizen> citizens = new List<ICitizen>();

			string input = Console.ReadLine();

			while (input != "End")
			{
				citizens.Add(AddCitizen(input));
				input = Console.ReadLine();
			}

			string fakeId = Console.ReadLine();
			Console.WriteLine();

			foreach (var citizen in citizens)
			{
				int lastThree = citizen.Id.Length - 3;

				if (citizen.Id.Substring(lastThree) == fakeId)
				{
					Console.WriteLine(citizen.Id);
				}
			}
		}

		private static ICitizen AddCitizen(string input)
		{
			var inputArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
			ICitizen citizen = null;

			if (inputArgs.Length == 3)
			{
				Human human = new Human(inputArgs[0], inputArgs[2], inputArgs[1]);
				citizen = human;
			}
			else if (inputArgs.Length == 2)
			{
				Robot robot = new Robot(inputArgs[1], inputArgs[0]);
				citizen = robot;
			}

			return citizen;
		}
	}
}
