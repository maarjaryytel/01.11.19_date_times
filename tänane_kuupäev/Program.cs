using System;

namespace tänane_kuupäev
{
	class Program
	{
		static void Main(string[] args)
		{
			var dateTime = new DateTime(2018, 11, 1); //igaks juhuks pannakse need andmed, et teised teaksid
													  //millal olen loonud, on teadlikult pandud 2018
			var currentDate = DateTime.Now;
			Console.WriteLine(currentDate);
			Console.ReadLine();

			//proovime nädalapäeva saada
			var dateObject = new DateTime(2019, 11, 01); //see rida on viimasele näitele
			var currentDayOfWeek = currentDate.DayOfWeek; //varri salvestatakse objekti, siia võib salvestada
			//ükskõik mida, kui panen varri, siis enam mälu ei kontrolli, ei ütle kui pikk on
			//var ei ole sõna, need on objektid
			//kui ma tahaksin kuvada seda kuupäeva, siis mul oleks vaja sõna ikkagi
			//selle variga saab defineerida ükskõik mida
			Console.WriteLine(currentDayOfWeek);
			Console.ReadLine();

			//kuidas ma saaks sellest sõna, on olemas sisseehitatud meetodit, mis lubavad sõna saada 

			//interneti alguse aega kuvab, ticks on millisekund, ticks on long-tüüpi
			var ticks = dateObject.Ticks;
			Console.WriteLine($"Ticks {ticks} ");
			Console.ReadLine();


		}
	}
}
