using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_7._Food_Shortage
{
	class StartUp
	{
		static void Main()
		{
			int n = int.Parse(Console.ReadLine());

			List<ICitizen> people = new List<ICitizen>();

			for (int i = 0; i < n; i++)
			{
				var peopleInput = Console.ReadLine();
				people.Add(GetPeople(peopleInput));
			}

			var buyer = Console.ReadLine();
			ProcessPurchases(buyer, people);

			var totalFoodBought = people.Sum(c => c.Food);
			Console.WriteLine(totalFoodBought);
		}

		private static void ProcessPurchases(string buyer, List<ICitizen> people)
		{
			while (buyer != "End")
			{
				foreach (var person in people)
				{
					if (person.Name == buyer)
					{
						if (person is Citizen)
						{
							person.BuyFood();
						}
						else if (person is Rebel)
						{
							person.BuyFood();
						}
					}
				}

				buyer = Console.ReadLine();
			}
			
		}

		private static ICitizen GetPeople(string peopleInput)
		{
			var peopleArgs = peopleInput.Split(" ", StringSplitOptions.RemoveEmptyEntries);
			ICitizen person = null;

			if (peopleArgs.Length == 4)
			{
				Citizen citizen = new Citizen(peopleArgs[0], peopleArgs[1], peopleArgs[2], peopleArgs[3]);
				person = citizen;
			}
			else
			{
				Rebel rebel = new Rebel(peopleArgs[0], peopleArgs[1], peopleArgs[2]);
				person = rebel;
			}

			return person;
		}
	}
}
