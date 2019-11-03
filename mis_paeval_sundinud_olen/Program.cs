using System;

namespace mis_paeval_sundinud_olen
{
	class Program
	{
		static void Main(string[] args)
		{
			string userInput;
			Console.WriteLine("Enter your date of birth (yyyy/mm/dd): ");
			userInput = Console.ReadLine();

			//split loob massiivi stringist
			string[] userData = userInput.Split('/'); //vahemälus luuakse uus massiiv, kuhu salvestatakse kasutaja andmed
			int year = int.Parse(userData[0]);
			int month = int.Parse(userData[1]);
			int day = int.Parse(userData[2]);

			//loome objekti, milleks on kasutaja sünnipäev

			var userBirthday = new DateTime(year, month, day);
			var birthdayDayOfTheWeek = userBirthday.DayOfWeek;
			Console.WriteLine($"You are borned: {birthdayDayOfTheWeek}");
			
			Console.ReadLine();
		}

	}

}

