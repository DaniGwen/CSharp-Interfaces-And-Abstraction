using Problem_8._Military_Elite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


public class LeutenantGeneral : ISoldier, IPrivate
{
	public string Id { get; set; }
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public string Corps { get; set; }
	public double Salary { get; set; }

	public List<Private> privates;

	public LeutenantGeneral() { }

	public LeutenantGeneral(string id, string firstName, string lastName, double salary) : this()
	{
		this.privates = new List<Private>();

		this.Id = id;
		this.FirstName = firstName;
		this.LastName = lastName;
		this.Salary = salary;
	}

	public void AddPrivates(Private pr)
	{
		this.privates.Add(pr);
	}

	public override string ToString()
	{
		StringBuilder sb = new StringBuilder();
		sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary}")
			.AppendLine($"Privates:");

		foreach (var soldier in privates)
		{
			sb.Append(soldier.ToString());
		}

		return sb.ToString();
	}
}

