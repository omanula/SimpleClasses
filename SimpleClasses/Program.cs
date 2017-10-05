using System;

namespace SimpleClasses
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			// instance of a class - known as an object (created from blueprint)
			// each object is distinct from others
			Car myNewCar = new Car();

            myNewCar.Make = "Oldsmobile";
            myNewCar.Model = "Cutlas Supreme";
            myNewCar.Year = 1986;
            myNewCar.Color = "Silver";
            // as long as using this instance, these will stay in memory
        }
    }

    class Car
    { // class - the blueprint
        // what we define here are the members of the class (properties/methods)
        // method: body of code that the class can DO

        public string Make { get;  set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set;}

        // create a new instance of class for each car -- use word new
    }


}
