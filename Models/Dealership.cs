using System;
using System.Collections.Generic;
using Dealership;

namespace Dealership.Models {
    class Car {
        private string _makeModel;
        private int _price;
        private int _miles;
        private string _description;

        public Car (string makeModel, int price, int miles, string description) {
            _makeModel = makeModel;
            _price = price;
            _miles = miles;
            _description = description;
        }

        public string GetMakeModel () {
            return _makeModel; //now every time we want to use or reference makeModel, we have to call GetMakeModel (line 40 of Program.cs)
        }
        public int GetPrice () {
            return _price;
        }

        public int GetMiles () {
            return _miles;
        }
         public string GetDescription () {
            return _description;
        }

        public static string SetSound(string newSound)
        {
             return "Our cars sound like " + newSound;
        }
         public void SetPrice(int newPrice)
        {
        _price = newPrice;
        }

        public bool WorthBuying (int maxPrice) {
            return (_price < maxPrice);
        }

        public bool WorthDriving (int maxMileage) {
            return (_miles < maxMileage);
        }

        public static string showCarToUser (string carToShow, List<Car> Cars) {
            if (carToShow == "volkswagen") {
                Console.WriteLine (Cars[0].GetDescription());
                return Cars[0].GetDescription();
            } else if (carToShow == "yugo") {
                Console.WriteLine (Cars[1].GetDescription());
                return Cars[1].GetDescription();
            } else if (carToShow == "ford") {
                Console.WriteLine (Cars[2].GetDescription());
                return Cars[2].GetDescription();
            } else {
                Console.WriteLine (Cars[3].GetDescription());
                return Cars[3].GetDescription();
            }
        }

    }
}