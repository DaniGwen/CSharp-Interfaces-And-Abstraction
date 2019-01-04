using Problem_8._Military_Elite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

public class SpecialisedSoldier : ISpecialisedSoldier
{
	public List<Soldier> Airforce { get; set; }
	public List<Soldier> Marines { get; set; }

	public SpecialisedSoldier()
	{

	}

	public void AddSoldierToCorps(Soldier soldier)
	{

		switch (soldier.Corps)
		{
			case "Marines":
				Marines.Add(soldier);
				break;
			case "Airforces":
				Airforce.Add(soldier);
				break;
			default: throw new Exception("No such Corps!");
		}
	}
}

