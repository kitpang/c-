using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Guessing game: type in an integer number and see if it is the same as mine!!!");

      int guess;
      int userGuess;
      // Creates a random number object
      Random rand = new Random();
      // Restricts the number between 1 and 11.
      guess = rand.Next(1, 11);

      do
      {
        userGuess = Convert.ToInt32(Console.ReadLine());

        if (userGuess < guess)
        {
          Console.WriteLine(userGuess + " is less than the number I am thinking of...");
        }
        else if (userGuess > guess)
        {
          Console.WriteLine(userGuess + " is greater than the number I am thinking of...");
        }

      }

      while (userGuess != guess);
      Console.WriteLine("Congratulations! You have won!");
      Console.ReadLine();

    }
  }
}
