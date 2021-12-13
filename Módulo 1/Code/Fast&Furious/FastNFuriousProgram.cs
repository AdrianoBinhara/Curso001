using CommandDotNet;
using ConsoleTables;
using System.Linq;

namespace FastFurious
{
    [Command(
        Description = "Lista os filmes, personagens e carros"
    )]
    public class FastNFuriousProgram
    {
        [Command(
            Description = "Lista os atores"
        )]
        public void Actors()
        {
            ConsoleTable
                .From(People.GetPeople())
                .Write();
        }

        [Command(
            Description = "Lista os filmes"
        )]
        public void Movies()
        {
            ConsoleTable
                .From(Films.GetFilms())
                .Write();
        }

        [Command(
            Description = "Lista os carros"
        )]
        public void Vehicles()
        {
            ConsoleTable
                .From(Cars.GetCars())
                .Write();
        }
    }
}