using Problem_8._Military_Elite.Classes;
using System;
using System.Collections.Generic;
using System.Text;


public class Engineer : ISoldier, IPrivate
{
	List<Repair> repairs;

	public Engineer()
	{
	}

	public Engineer(string id, string firstName, string lastName, double salary, string corps) : this()
	{
		repairs = new List<Repair>();

		this.Id = id;
		this.FirstName = firstName;
		this.LastName = lastName;
		this.Corps = corps;
		this.Salary = salary;
	}

	public double Salary { get; set; }
	public string Id { get; set; }
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public string Corps { get; set; }

	public void AddRepairs(Repair repair)
	{
		repairs.Add(repair);
	}

	public override string ToString()
	{
		StringBuilder sb = new StringBuilder();
		sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary}")
		.AppendLine($"Corps: {this.Corps}")
		.AppendLine("Repairs:");

		foreach (var repair in repairs)
		{
			sb.Append($"  {repair.ToString()}");
		}

		return sb.ToString();
	}
}

