using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_7._Food_Shortage
{
	public class Rebel : ICitizen
	{
		private int food;
		private string group;
		private string age;

		public Rebel(string name, string age, string group)
		{
			this.Name = name;
			this.Age = age;
			this.Group = group;
			this.Food = 0;
		}

		public void BuyFood()
		{
			this.Food += 5;
		}

		public string Age
		{
			get { return age; }
			set { age = value; }
		}
		public int Food
		{
			get { return food; }
			set { food = value; }
		}
		public string Group
		{
			get { return group; }
			set { group = value; }
		}
		public string Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public string Name { get; set; }
		public string Birthday { get => throw new InvalidOperationException(); set => throw new InvalidOperationException(); }
	}
}
