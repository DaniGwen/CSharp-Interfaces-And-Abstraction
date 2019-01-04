using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_8._Military_Elite.Interfaces
{
	public interface ISpecialisedSoldier
	{
		List<Soldier> Airforce { get; set; }
		List<Soldier> Marines { get; set; }
	}
}
