using System;
using System.Collections.Generic;
using System.Text;


public interface ICitizen : IBuyer
{
	string Id { get; set; }
	string Name { get; set; }
	string Birthday { get; set; }
}

