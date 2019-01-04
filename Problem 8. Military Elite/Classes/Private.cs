using System;
using System.Collections.Generic;
using System.Text;


public class Private : IPrivate, ISoldier
{
	public Private(string id, string firstName, string lastName, double salary)
	{
		this.Id = id;
		this.FirstName = firstName;
		this.LastName = lastName;
		this.Salary = salary;
	}

	public string Id { get; set; }
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public string Corps { get; }
	public double Salary { get; set; }

	public override string ToString()
	{
		StringBuilder sb = new StringBuilder();

		sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {Id} Salary: {this.Salary:f2}");

		return sb.ToString();
	}
}

