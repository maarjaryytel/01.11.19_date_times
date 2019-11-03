using System;
using System.Collections.Generic; //kui on vaja midagi lisaks teha, siis kirjutan ise siia rea juurde
//seda Generic on vaja Listi jaoks, ilma selleta ei tööta

namespace minu_vanus_sekundites
{
	class Program
	{
		static void Main(string[] args)
		{
			//List-tüüp
			//massiivi juurde lisamiseks on olemas list-tüüpi objektid
			//see on see kuidas deklareerime andmeid
			//listis on ühte tüüpi andmed olla

			var numbers = new List<int>() { 1, 2, 3, 4, 5 }; //see ei ole massiiv, massiivi sulge ei ole

			//listide puhul võime lisada midagi juurde,
			//listid on dünaamilised, esialgsesse massiivi midagi juurde lisada enam ei saa

			numbers.Add(1); //lisas veel ühe numbri juurde- nr 100, muudab selle listi pikkuse
			numbers.AddRange(new int[3] { 6, 7, 8 }); //lisab juurde numbrid 6,7,8
			
			foreach (int element in numbers)
			{
				Console.WriteLine(element);
			}

			int index = numbers.IndexOf(1);
			Console.WriteLine($"value of IndexOf: {index}"); //näitab indeksiks 0.
			int lastIndex = numbers.LastIndexOf(1);
			Console.WriteLine($"value of LastIndexOf: {lastIndex}"); //võttis 5.nda koha

			//kustutan kindla koha peal oleva numbri selle RemoveAT, koos for each
			//numbers.RemoveAt(lastIndex); //eemaldas viimase numbri, ehk numbri 1.
			
			foreach (int element in numbers)
			{
				Console.WriteLine(element);
			}


			//kui me tahame selle listi suurust teada
			int sizeOfList = numbers.Count; //see om omadus, mitte meetod- property, 
			//listidega töötades on countid
			//count- mitu elementi on massiivi sees
			//tööriista märgiga on konsoolis omadused- count nt
			//lilla blönn- see oli meetod
			Console.WriteLine($"Your list is {sizeOfList} long.");

			//tahan kõik 1-d ära kustutada,  otsime k'ik 1-d ülesse
			//ja seejärel kustutame ära			
			//foreachi ajal ei tohin numbreid eemaldada

			for (int i = 0; i < numbers.Count; i++) //ta ei taha kindlat suurust, vaid tahab listi suurust saada. Sizeoflist ei sobi seega
			{
				if (numbers [i] == 1)
				{
					numbers.Remove(numbers[i]);
				}
			}
			foreach (int element in numbers)
			{
				Console.WriteLine(element);
			}
			
			//puhastame kõik elemendid ära
			numbers.Clear();


			foreach (int element in numbers)
			{
				Console.WriteLine($"List after Clear () {element}");
			}



			Console.ReadLine();
		}
	}
}
