using System.Collections.Generic;

namespace FastFurious
{
    public class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
    }
    public static class Cars
    {
        public static IEnumerable<Vehicle> GetCars()
        {
            yield return new Vehicle
            {
                Name = "Dodge Charger R/T",
                Model = "Dodge"
            };
            yield return new Vehicle
            {
                Name = "GTR R34s",
                Model = "Nissan"
            };
            yield return new Vehicle
            {
                Name = "Supra",
                Model = "Toyota"
            };
            yield return new Vehicle
            {
                Name = "Corvette Stingray",
                Model = "Chevrolet"
            };
        }
    }
}