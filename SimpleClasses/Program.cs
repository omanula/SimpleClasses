using System;

namespace SimpleClasses
{

    // A class is a datatype in .net similar to basic datatypes (string, int)
    // define a custom class with properties and methods, then create instances
    // Access objects with . operator

    class MainClass
    {
        public static void Main(string[] args)
        {
			// instance of a class - known as an object (created from blueprint)
			// each object is distinct from others
			Car myNewCar = new Car();

            // SETTING the properties
            myNewCar.Make = "Oldsmobile";
            myNewCar.Model = "Cutlas Supreme";
            myNewCar.Year = 1986;
            myNewCar.Color = "Silver";
            // as long as using this instance, these will stay in memory

            // GETTING the properties
            Console.WriteLine("{0} - {1} - {2}",
                              myNewCar.Make,
                              myNewCar.Model,
                              myNewCar.Color);

            //double marketValueOfCar = determineMarketValue(myNewCar);

            // C - currency value
            Console.WriteLine("Car's value: {0:C}", myNewCar.DetermineMarketValue());

            Console.ReadLine();
        }

        // C-Car is the data type, c-car is the name
        private static double determineMarketValue(Car _car)
        {
            double carValue = 100.0;

            // Somedat white come to go online and look up the car's value
            // and trieve its value into the carValue variable

            return carValue;
        }

    }
    // When creating a class, you create a custom data type
    // Data type is accepted anywhere when established in the class

    class Car
    { // class - the blueprint
        // what we define here are the members of the class (properties/methods)
        // method: body of code that the class can DO

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        // create a new instance of class for each car -- use word new

        public double DetermineMarketValue()
        {

            double carValue = 100.0;

            // this. allows you to access all under the Car class, shows identifier
            if (this.Year > 1990)
                carValue = 10000.0;
            else
                carValue = 2000.0;

            return carValue; 
        }
    }


}
