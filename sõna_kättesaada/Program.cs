using System;

namespace sõna_kättesaada
{
	class Program
	{
		static void Main(string[] args)
		{
			//hetke kuupäev ja kellaaeg
			var currentDate = DateTime.Now;
			Console.WriteLine($"Print current date: {currentDate}");

			//kuvab päeva (eesti keeles), kuupäeva, kellaaja pikas formaadis
			Console.WriteLine($"Print long date string: {currentDate.ToLongDateString()}");

			//kuvab numbritega, ilma kellaajata
			Console.WriteLine($"Print short date string: {currentDate.ToShortDateString()}");

			//kuvab sekunditega
			Console.WriteLine($"Print long time string: {currentDate.ToLongTimeString()}");

			//sekundeid ei kuva
			Console.WriteLine($"Print long time string: {currentDate.ToShortTimeString()}");

			Console.WriteLine($"Date format: {currentDate.ToString("dd-MM-yyy hh:MM")}");
			//suur MM on kuu ja väike mm on minut
			//kui väike hh -siis on 12-tunnine periood, kui suured HH- siis 24-tunnine periood

			Console.ReadLine();

		}
	}
}
