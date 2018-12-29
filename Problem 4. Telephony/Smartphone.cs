using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem_4._Telephony
{
	public class Smartphone : ICallable, IBrowsable
	{

		public Smartphone() { }

		public void CallNumber(string input)
		{
			var numbers = input.Split();

			foreach (var number in numbers)
			{
				Console.WriteLine("Calling... {0}", number);
			}
		}

		public void BrowseSite(string input)
		{
			var sites = input.Split();

			Regex regex = new Regex(@"\G\S+([a-zA-Z])+(://)[a-zA-Z]+.[a-zA-Z]+$");

			foreach (var site in sites)
			{
				if (regex.IsMatch(site))
				{
					Console.WriteLine("Browsing: {0}!", site);
				}
				else
				{
					Console.WriteLine("Invalid URL!");
				}
			}
		}
	}
}
