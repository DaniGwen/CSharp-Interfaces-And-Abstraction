using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_8._Military_Elite.Classes
{
	public class Mission
	{
		public string CodeName { get; set; }
		public string Progress { get; set; }

		public Mission() { }

		public Mission(string name, string progress) : this()
		{
			this.CodeName = name;
			this.Progress = progress;
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine($"Code Name: {this.CodeName} State: {this.Progress}");

			return sb.ToString();
		}
	}
}
