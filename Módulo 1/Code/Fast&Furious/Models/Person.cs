using System.Collections.Generic;

namespace FastFurious
{
    public class Person
    {
        public string Name { get; set; }
        public string Actor { get; set; }
        public string Vehicle { get; set; }

    }
    public static class People
    {
        public static IEnumerable<Person> GetPeople()
        {
            yield return new Person
            {
                Name = "Brian O'Connor",
                Actor = "Paul Walker",
                Vehicle = "Supra"
            };
            yield return new Person
            {
                Name = "Dominic Toretto",
                Actor = "Vin Diesel",
                Vehicle = "Dodge Charger R/T"
            };
            yield return new Person
            {
                Name = "Letty Ortiz",
                Actor = "Michelle Rodriguez",
                Vehicle = "Corvette Stringray"
            };
        }
    }
}