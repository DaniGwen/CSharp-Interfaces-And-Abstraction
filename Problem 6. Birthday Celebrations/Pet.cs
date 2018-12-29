using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_6._Birthday_Celebrations
{
	public class Pet : ICitizen
	{
		private string name;
		private string birthday;
		public string Id { get; set; }

		public Pet(string name, string birthday)
		{
			this.Name = name;
			this.Birthday = birthday;
		}

		public string Name
		{
			get { return name; }
			set
			{
				name = value;
			}
		}
		public string Birthday
		{
			get { return birthday; }
			set { birthday = value; }
		}
	}
}
