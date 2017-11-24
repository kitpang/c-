using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Exercise
{
	class Program
	{
		static void Main(string[] args)
		{
			string instruction;
			string key;
			string value;

			Dictionary<string, string> codingLanguages = new Dictionary<string, string>();

			codingLanguages.Add("C#", "The best program");
			codingLanguages.Add("Java", "Named after a cofee");
			codingLanguages.Add("Scratch", "Cool for kids");

			do
			{
				Console.Clear();
				Console.WriteLine("Coding languages dictionary. \nType K to look for a language, \nD to look for a dscription, \nL to use a key to look up a value, \nC to count the list, \nA to list all entries, \nAdd to add new dictionary entries, \nRemove to remove existing dictionary entries and \nX to exit:");
				instruction = Convert.ToString(Console.ReadLine().ToLower());

				switch (instruction)
				{
					case "k":
						Console.WriteLine("Please enter the key");
						key = Convert.ToString(Console.ReadLine());

						if (codingLanguages.ContainsKey(key))
						{
							Console.WriteLine("The \"{0}\" key exists in the dictionary!", key);
						}
						else
						{
							Console.WriteLine("The \"{0}\" key does not exists in the dictionary!", key);
						}
						Console.ReadLine();
						break;
					case "d":
						Console.WriteLine("Please enter the value");
						value = Convert.ToString(Console.ReadLine());

						if (codingLanguages.ContainsValue(value))
						{
							Console.WriteLine("\"{0}\" exists in the dictionary!", value);
						}
						else
						{
							Console.WriteLine("\"{0}\" does not exists in the dictionary!", value);
						}
						Console.ReadLine();
						break;
					case "l":
						Console.WriteLine("Please enter the key");
						key = Convert.ToString(Console.ReadLine());
						string result;
						bool found;
						found = codingLanguages.TryGetValue(key, out result);
						Console.WriteLine(result);
						Console.ReadLine();
						break;
					case "a":
						foreach (KeyValuePair<string, string> language in codingLanguages)
						{
							Console.WriteLine(language);
						}
						Console.ReadLine();
						break;
					case "c":
						Console.WriteLine(codingLanguages.Count());
						Console.ReadLine();
						break;
					case "add":
						Console.WriteLine("Please enter the programming language");
						key = Convert.ToString(Console.ReadLine());
						Console.WriteLine("Please enter the language's description");
						value = Convert.ToString(Console.ReadLine());

						codingLanguages.Add(key, value);
						Console.WriteLine("\"{0}\" and \"{1}\" has been added as a dictionary entry!", key, value);
						Console.ReadLine();
						break;
					case "remove":
						Console.WriteLine("Please enter the key to delete");
						key = Convert.ToString(Console.ReadLine());
						codingLanguages.Remove(key);
						Console.WriteLine("\"{0}\" has been deleted from the dictionary!", key);
						Console.ReadLine();
						break;
					default:
						break;

				}

			} while (instruction != "x");


		}
	}
}

