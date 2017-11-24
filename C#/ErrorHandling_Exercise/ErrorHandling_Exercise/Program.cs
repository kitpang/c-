using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ErrorHandling_Exercise
{
	class Program
	{
		static void Main(string[] args)
		{

			StreamReader sr = null;
			string[] stringArray = new string[1];
			int value =  7 ;

			try
			{
				//stringArray[3] = "Catch me if you can!";

				//sr = File.OpenText(@"c:\Users\Louisem\mydata.txt");
				//Console.WriteLine(sr.ReadToEnd());

				//int first = 1;
				//int second = 0;
				//int result = first / second;

				Console.WriteLine("{0} divided by 2 is {1}", value, DivideByTwo(value));

			}

			catch (FileNotFoundException fnfe)
			{
				Console.WriteLine("{0}: {1}", fnfe.GetType().Name, fnfe.Message);
			}

			catch (IndexOutOfRangeException ioore)
			{
				Console.WriteLine("{0}: {1}", ioore.GetType().Name, ioore.Message);
			}

			catch (DivideByZeroException dbze)
			{
				Console.WriteLine("{0}: {1}", dbze.GetType().Name, dbze.Message);
			}

			catch (ArgumentException e)
			{
				Console.WriteLine("{0}: {1}", e.GetType().Name, e.Message);
			}

			catch (Exception ex)
			{
				Console.WriteLine("{0}: {1}", ex.GetType().Name, ex.Message);
			}

			Console.WriteLine("...and the program continues...");
			Console.ReadLine();
		}//end main

		static int DivideByTwo(int num)
		{
			// If num is an odd number, throw an ArgumentException.
			if ((num & 1) == 1)
				throw new ArgumentException(String.Format("{0} is not an even number", num),
										  "num");

			// num is even, return half of its value.
			return num / 2;
		}
	}//end class
}//end namespace

// https://msdn.microsoft.com/en-us/library/system.argumentexception(v=vs.110).aspx 