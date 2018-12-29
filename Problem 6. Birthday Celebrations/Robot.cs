using System;
using System.Collections.Generic;
using System.Text;


public class Robot : ICitizen
{
	public string Id { get; set; }
	private string model;
	public string Name { get; set; }
	public string Birthday { get; set; }

	public Robot(string id, string model)
	{
		this.Id = id;
		this.Model = model;
	}

	public string Model
	{
		get { return model; }
		set { model = value; }
	}
}

