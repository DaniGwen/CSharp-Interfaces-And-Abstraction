using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class PriceCalculator
{
	private object inputArgs;

	public decimal PricePerDay { get; private set; }
	public int NumberOfDays { get; private set; }
	public string Season { get; private set; }
	private double TotalPrice;


	public PriceCalculator(string input)
	{
		string[] inputArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

		this.PricePerDay = decimal.Parse(inputArgs[0]);
		this.NumberOfDays = int.Parse(inputArgs[1]);
		this.Season = inputArgs[2];

		TotalPrice = (double)PricePerDay * NumberOfDays;

		switch (Season)
		{
			case "Spring":
				TotalPrice *= 2;
				break;
			case "Autumn":
				TotalPrice *= 1;
				break;
			case "Summer":
				TotalPrice *= 4;
				break;
			case "Winter":
				TotalPrice *= 3;
				break;
		}

		if (inputArgs.Length > 3)
		{
			string discountType = inputArgs[3];
			double discount;

			switch (discountType)
			{
				case "VIP":
					discount = TotalPrice * 0.20;
					TotalPrice -= discount;
					break;
				case "SecondVisit":
					discount = TotalPrice * 0.10;
					TotalPrice -= discount;
					break;
				case "None":
					break;
			}
		}

		Console.WriteLine($"{TotalPrice:f2}");
	}

}

