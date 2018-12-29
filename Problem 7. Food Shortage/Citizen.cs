using System;
using System.Collections.Generic;
using System.Text;


public class Citizen : ICitizen
{

	private string age;
	private string name;
	private int food;

	public Citizen(string name, string age, string Id, string birthday)
	{
		this.Name = name;
		this.Id = Id;
		this.Age = age;
		this.Birthday = birthday;
		this.Food = 0;
	}

	public void BuyFood()
	{
		this.Food += 10;
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
	public string Id { get; set; }
	public string Birthday { get; set; }
	public int Food
	{
		get { return food; }
		set { food = value; }
	}
}

