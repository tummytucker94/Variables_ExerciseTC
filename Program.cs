using System;

namespace Variable_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            			string pokemonName = "Charmander";
			int pokedexNum = 004;
			char firstLetter = 'c';
			bool isAFireType = true;
			double weight = 19.0;
			decimal height = 2.0m;
			
			//used interpolated strings
			Console.WriteLine($"{pokemonName} is a first-gen pokemon that is number {pokedexNum} in the PokeDex. The first letter in its name begins with a {firstLetter}, and it is {isAFireType} that he is a fire type. Additionally, its weight is {weight}lbs and its height is {height}ft. ");
        }
    }
}
