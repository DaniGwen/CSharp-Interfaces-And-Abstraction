using System;
using System.Collections.Generic;

namespace Problem_6._Birthday_Celebrations
{
	class StartUp
	{
		static void Main()
		{
			List<ICitizen> citizens = new List<ICitizen>();

			string command = Console.ReadLine();

			while (command != "End")
			{
				citizens.Add(AddCitizens(command));

				command = Console.ReadLine();
			}
			string dateToPrint = Console.ReadLine();

			PrintCelebratingThisYear(citizens, dateToPrint);
		}

		private static void PrintCelebratingThisYear(List<ICitizen> citizens, string dateToPrint)
		{
			foreach (var citizen in citizens)
			{
				if (citizen is Robot)
				{
					continue;
				}
				else if (citizen.Birthday.Contains(dateToPrint))
				{
					Console.WriteLine(citizen.Birthday);
				}
			}
		}

		private static ICitizen AddCitizens(string command)
		{
			ICitizen citizen = null;
			var commandArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

			switch (commandArgs[0])
			{
				case "Citizen":
					Human human = new Human(commandArgs[1], commandArgs[3], commandArgs[2], commandArgs[4]);
					citizen = human;
					break;
				case "Pet":
					Pet pet = new Pet(commandArgs[1], commandArgs[2]);
					citizen = pet;
					break;
				case "Robot":
					Robot robot = new Robot(commandArgs[2], commandArgs[1]);
					citizen = robot;
					break;
				default: throw new Exception("Forbiden!");
			}

			return citizen;
		}
	}
}
