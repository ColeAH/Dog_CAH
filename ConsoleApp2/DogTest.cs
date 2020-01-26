using System;

namespace ConsoleApp2 {
	class DogTest {
		static void Main(string[] args) {
			Console.WriteLine("Hello World!");

			Dog rover = new Dog();
			Dog pluto = new Dog(4, "Pluto");

			rover.setName("Rover");
			rover.setAge(3);
			Console.Write("The first dog's name is " + rover.getName() + ". ");
			Console.Write("Rover is " + rover.getAge() + " years old. ");
			Console.Write("This is " +rover.calcDogYears() + " in dog years.");


			Console.Write("\nThe second dog's name is " + pluto.getName() + ". ");
			Console.Write("Pluto is " + pluto.getAge() + " years old. ");
			Console.Write("This is " + pluto.calcDogYears() + " in dog years.");

			Console.WriteLine("\nThe dogs are " + rover.toString() + " and " + pluto.toString() + ".");
		}


	}
}
