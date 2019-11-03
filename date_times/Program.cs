using System;

namespace date_times
{
	class Program
	{
		static void Main(string[] args)
		{
			//see ei ole kindla tüübiga
			var dateToday = new DateTime(2019, 11, 1);
			
			Console.WriteLine(dateToday);
			
			var dayOfTheWeek = dateToday.DayOfWeek;
			//dayof the week ei ole meetod, see on omadus
			Console.WriteLine(dayOfTheWeek);


			Console.ReadLine();
		}
	}
}
