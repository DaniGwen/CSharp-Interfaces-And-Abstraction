using System;

namespace Problem_4._Telephony
{
	class StartUp
	{
		static void Main()
		{
			string numbers = Console.ReadLine();

			Smartphone myPhone = new Smartphone();
			myPhone.CallNumber(numbers);

			string sites = Console.ReadLine();
			myPhone.BrowseSite(sites);
		}
	}
}
