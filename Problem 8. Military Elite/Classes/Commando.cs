using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_8._Military_Elite.Classes
{
	public class Commando : IPrivate, ISoldier
	{
		List<Mission> Missions;

		public string Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Corps { get; set; }
		public double Salary { get; set; }

		public Commando()
		{
		}

		public Commando(string id, string firstName, string lastName, double salary, string corps) : this()
		{
			this.Missions = new List<Mission>();

			this.Id = id;
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Corps = corps;
			this.Salary = salary;
		}

		public void AddMissions(Mission mission)
		{
			this.Missions.Add(mission);
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary}")
				.AppendLine($"Corps: {this.Corps}")
				.AppendLine("Missions:");

			foreach (var mission in Missions)
			{
				sb.Append($"  {mission.ToString()}");
			}
			return sb.ToString();
		}
	}
}
