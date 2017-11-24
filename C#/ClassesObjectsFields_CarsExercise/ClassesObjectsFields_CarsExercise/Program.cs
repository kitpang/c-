using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjectsFields_CarsExercise
{
	class Program
	{
		static void Main(string[] args)
		{
			// MN: This is not the best way to instantiate objects.

			// instantiating the car sold varaible
			Car.carsSold = 0;

			// instantiating a car object
			Car car1 = new Car();
			car1.make = "Toyota";
			car1.model = "Yaris";
			car1.price = 15000;
			car1.sold = true;
			Car.carsSold++;

			// car2
			Car car2 = new Car();
			car2.make = "Honda";
			car2.model = "Civic";
			car2.price = 16500;
			car2.sold = true;
			Car.carsSold++;

			// car3
			Car car3 = new Car();
			car3.make = "Ford";
			car3.model = "Focus";
			car3.price = 10000;
			car3.sold = false;
			Car.carsSold++;

			// output
			Console.WriteLine("Total number of cars in stock is: " + Car.carsSold + "\n");

			Console.WriteLine("The details of this car are: ");
			Console.WriteLine("Make and model: " + car1.make + " " + car1.model + "\nPrice: " + car1.price + "\n");

			Console.WriteLine("The details of this car are: ");
			Console.WriteLine("Make and model: " + car2.make + " " + car2.model + "\nPrice: " + car2.price + "\n");

			Console.WriteLine("The details of this car are: ");
			Console.WriteLine("Make and model: " + car3.make + " " + car3.model + "\nPrice: " + car3.price + "\n");

			Console.ReadLine();

			// { N : 0} formatting adds a comma for the prices
		}

		public class Car
		{
			// non-static or instance fields
			public string make = "";
			public string model = "";
			public int price = 0;
			public bool sold;

			// static fields
			public static int carsSold;
		}
	
	}
}

