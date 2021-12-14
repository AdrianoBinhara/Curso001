using System.Collections.Generic;

namespace FastFurious
{
    public class Movie
    {
        public string Name { get; set; }
        public int Date { get; set; }   
    }

    public static class Films
    {
        public static IEnumerable<Movie> GetFilms()
        {
            yield return new Movie
            {
                Name = "The Fast and the Furious",
                Date = 2001
            };
            yield return new Movie
            {
                Name = "2 FAST 2 FURIOUS",
                Date = 2003
            };
            yield return new Movie
            {
                Name = "FAST & FURIOUS",
                Date = 2009
            };
            yield return new Movie
            {
                Name = "FAST FIVE",
                Date = 2011
            };
            yield return new Movie
            {
                Name = "THE FAST AND THE FURIOUS: TOKYO DRIFT",
                Date = 2006
            };
            yield return new Movie
            {
                Name = "FAST & FURIOUS 6",
                Date = 2013
            };
            yield return new Movie
            {
                Name = "FURIOUS 7",
                Date = 2015
            };
            yield return new Movie
            {
                Name = "THE FATE OF THE FURIOUS",
                Date = 2017
            };
             yield return new Movie
            {
                Name = "FAST & FURIOUS PRESENTS: HOBBS & SHAW",
                Date = 2019
            };
            yield return new Movie
            {
                Name = "F9 THE FAST SAGA",
                Date = 2021
            };
        }

    }

}