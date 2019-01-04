using System;
using System.Collections.Generic;
using System.Text;


public class Soldier : ISoldier,IPrivate
{
	public string Id { get; set; }
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public string Corps { get; set; }
	public double Salary { get ; set ; }

	public Soldier(string id, string firstName, string lastName, double salary, string corps)
	{
		this.Id = id;
		this.FirstName = firstName;
		this.LastName = LastName;
		this.Corps = corps;
		this.Salary = salary;
	}
}

