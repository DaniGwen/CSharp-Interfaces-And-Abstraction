using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_8._Military_Elite.Classes
{
	public class Repair
	{
		public string PartName { get; set; }
		public string HoursWorked { get; set; }

		public Repair() { }

		public Repair(string part, string hours) : this()
		{
			this.PartName = part;
			this.HoursWorked = hours;
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine($"Part Name: {PartName} Hours Worked: {HoursWorked}");

			return sb.ToString();
		}
	}
}
