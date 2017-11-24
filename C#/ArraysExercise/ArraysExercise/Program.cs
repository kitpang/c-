using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysExercise
{
  class Program
  {
    static void Main(string[] args)
    {
      //double[] numbers = new double[5];
      //double average = 0;
      //double sum = 0;

      //for (int i = 0; i < numbers.Length; i++)
      //{
      //  Console.WriteLine("Type in the {0}th number", i + 1);
      //  numbers[i] = Convert.ToDouble(Console.ReadLine());
      //}

      //foreach (double number in numbers)
      //{
      //  sum += number;
      //}

      //average = sum / numbers.Length;

      //Console.WriteLine(average);

      Console.WriteLine("What dimension do you want the array to be?");
      int dimensionSize = Convert.ToInt32(Console.ReadLine());

      int[,] grid = new int[dimensionSize, dimensionSize];


      Random rand = new Random();
      int[] rowTotals = new int[dimensionSize];
      int[] columnTotals = new int[dimensionSize];
      int overallTotal = 0;
      for (int i = 0; i < grid.GetLength(0); i++)
      {
        for (int j = 0; j < grid.GetLength(1); j++)
        {
          //fill grid with random numbers
          grid[i, j] = rand.Next(1, 11);
          //display grid
          Console.Write(grid[i, j] + "\t");
          //calculate totals
          rowTotals[i] += grid[i, j];
          columnTotals[j] += grid[i, j];
          overallTotal += grid[i, j];
        }
        Console.WriteLine();
      }
      for (int i = 0; i < rowTotals.Length; i++)
      {
        Console.WriteLine("The total of row " + (i + 1) + " is " + rowTotals[i]);
      }
      for (int i = 0; i < columnTotals.Length; i++)
      {
        Console.WriteLine("The total of column " + (i + 1) + " is " + columnTotals[i]);
      }
      Console.WriteLine("The overall total is: " + overallTotal);

      Console.ReadLine();
    }
  }
}
