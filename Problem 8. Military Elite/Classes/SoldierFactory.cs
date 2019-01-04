using Problem_8._Military_Elite.Classes;
using System;
using System.Collections.Generic;
using System.Text;


public class SoldierFactory
{
	public SoldierFactory()
	{

	}

	public List<ISoldier> MakeSoldiers(string input)
	{
		ISoldier TypeOfSoldier = null;
		List<ISoldier> soldiers = new List<ISoldier>();

		while (input != "End")
		{
			var inputArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
			string id = inputArgs[1];
			string firstName = inputArgs[2];
			string lastName = inputArgs[3];

			switch (inputArgs[0])
			{
				case "Private":
					TypeOfSoldier = new Private(id, firstName, lastName, double.Parse(inputArgs[4]));
					soldiers.Add((Private)TypeOfSoldier);
					break;
				case "LeutenantGeneral":
					TypeOfSoldier = new LeutenantGeneral(id, firstName, lastName, double.Parse(inputArgs[4]));
					LeutenantGeneral leutenantGeneral = (LeutenantGeneral)TypeOfSoldier;

					for (int i = 4; i < inputArgs.Length; i++)
					{
						foreach (var soldier in soldiers)
						{
							if (soldier.Id == inputArgs[i])
							{
								leutenantGeneral.AddPrivates((Private)soldier);
							}
						}
					}
					soldiers.Add(leutenantGeneral);
					break;

				case "Engineer":
					TypeOfSoldier = new Engineer(id, firstName, lastName, double.Parse(inputArgs[4]), inputArgs[5]);
					Engineer engineer = (Engineer)TypeOfSoldier;

					for (int i = 6; i < inputArgs.Length; i++)
					{
						Repair repair = new Repair();
						repair.PartName = inputArgs[i];
						repair.HoursWorked = inputArgs[i + 1];
						engineer.AddRepairs(repair);
						i++;
					}

					soldiers.Add(engineer);
					break;

				case "Commando":
					TypeOfSoldier = new Commando(id, firstName, lastName, double.Parse(inputArgs[4]), inputArgs[5]);
					Commando commando = (Commando)TypeOfSoldier;

					for (int i = 6; i < inputArgs.Length; i++)
					{
						Mission mission = new Mission();
						mission.CodeName = inputArgs[i];
						mission.Progress = inputArgs[i + 1];
						commando.AddMissions(mission);
						i++;
					}

					soldiers.Add(commando);
					break;
				default:
					break;
			}
			input = Console.ReadLine();
		}

		return soldiers;
	}
}

