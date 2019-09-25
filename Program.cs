using System;
using System.Collections.Generic;
using Dealership.Models;


namespace Dealership {
    public class Program {
        public static void Main () {
            Car volkswagen = new Car ("1974 Volkswagen Thing", 1100, 368792, "oldest shitty car");
            Car yugo = new Car ("1980 Yugo Koral", 700, 56000, "old shitty car");
            Car ford = new Car ("1988 Ford Country Squire", 1400, 239001, "older shitty car");
            Car amc = new Car ("1976 AMC Pacer", 400, 198000, "shitty car");
            amc.SetPrice(200);

            List<Car> Cars = new List<Car> () { volkswagen, yugo, ford, amc };
            Console.WriteLine ("Which car would you like to see info on?");
            string carToShow = Console.ReadLine ();
            Car.showCarToUser (carToShow, Cars);

            Console.WriteLine ("Enter maximum price: ");
            string stringMaxPrice = Console.ReadLine ();
            int maxPrice = int.Parse (stringMaxPrice);
            Console.WriteLine ("Enter desired maximum mileage: ");
            string stringMaxMileage = Console.ReadLine ();
            int maxMileage = int.Parse (stringMaxMileage);

            List<Car> CarsMatchingSearch = new List<Car> (0);

            foreach (Car automobile in Cars) {
                if (automobile.WorthBuying (maxPrice) && automobile.WorthDriving (maxMileage)) {
                    CarsMatchingSearch.Add (automobile);
                }
            }
            

            if (CarsMatchingSearch.Count == 0) {
                Console.WriteLine ("You need mo scrilla");
            } else {
                foreach (Car automobile in CarsMatchingSearch) {
                    Console.WriteLine (automobile.GetMakeModel()); //compare to public version, where it's automobile.makeModel. We can't do that after making _makeModel private.
                    Console.WriteLine (automobile.GetDescription()); //use "automobile" because we are calling GetDescription on an instance of Car.
                    Console.WriteLine(Car.SetSound("Zip!")); //use "Car" because we are calling SetSound on the actual whole class of "Car". All cars go "Zip!"
                    Console.WriteLine(automobile.GetPrice());//use "automobile" because we are calling GetPrice on an instance of Car (in this case, the amc).
                }
            }

        }
    }

}