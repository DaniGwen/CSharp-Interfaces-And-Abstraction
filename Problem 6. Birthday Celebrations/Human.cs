using System;
using System.Collections.Generic;
using System.Text;


public class Human : ICitizen,IBirthable
{
	
	private string age;
	private string name;

	public Human(string name, string Id, string age, string birthday)
	{
		this.Name = name;
		this.Id = Id;
		this.Age = age;
		this.Birthday = birthday;
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
}

