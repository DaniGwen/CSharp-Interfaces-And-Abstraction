using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_8._Military_Elite.Classes
{
	public class Spy
	{
		public string FirstName { get; private set; }
		public string LastName { get; private set; }
		public string Id { get; private set; }
		public string CodeNumber { get; private set; }

		public Spy(string firstName, string lastName, string id)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Id = id;
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id}")
				.AppendLine($"Code Number: {CodeNumber}");

			return sb.ToString();
		}
	}
}
