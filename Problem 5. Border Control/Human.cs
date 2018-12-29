using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_5._Border_Control
{
	public class Human : ICitizen
	{
		public string Id { get; set; }
		private string age;
		private string name;
		private string birthday;

		public Human() { }

		public Human(string birthday)
		{
			this.Birthday = birthday;
		}

		public Human(string name, string Id, string age, string birthday) : this(birthday)
		{
			this.Name = name;
			this.Id = Id;
			this.Age = age;
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		public string Age
		{
			get { return age; }
			set { age = value; }
		}
		public string Birthday
		{
			get { return birthday; }
			set { birthday = value; }
		}
	}
}
