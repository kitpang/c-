using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachLoops_SevenDwarves
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] sevenDwarves = { "Happy", "Doc", "Sleepy", "Sneezy", "Dopey", "Bashful", "Grumpy" };

      //for (int i = 0; i < sevenDwarves.Length; i++)
      //{
      //  Console.WriteLine("Hey " + sevenDwarves[i] + ", dinner is ready!");
      //}

      //foreach (string dwarf in sevenDwarves)
      //{
      //  Console.WriteLine("Hey " + dwarf + ", your drink is ready!");

      string[] dinner = new string[sevenDwarves.Length];
      string[] drink = new string[sevenDwarves.Length];



      for (int i = 0; i < sevenDwarves.Length; i++)
      {
        Console.WriteLine("{0}, what dinner do you like?", sevenDwarves[i]);
        dinner[i] = Console.ReadLine();
        Console.WriteLine("{0}, what drink do you like?", sevenDwarves[i]);
        drink[i] = Console.ReadLine();

        if (dinner[i] != "")
        {
          Console.WriteLine("{0}, your {1} is ready", sevenDwarves[i], dinner[i]);
        }
        if (drink[i] != "")
        {
          Console.WriteLine("{0}, your {1} is ready", sevenDwarves[i], drink[i]);
        }

      }
    }
  }
}
