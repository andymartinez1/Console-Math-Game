using Math_Game.Models;

namespace Math_Game;

public class Helpers
{
    internal static List<Game> gamesPlayed = new List<Game>();

    internal static void PrintGames()
    {
        Console.Clear();
        Console.WriteLine("Game History:");
        Console.WriteLine("----------------------------------------------------");
        
        if (gamesPlayed.Count == 0)
        {
            Console.WriteLine("No Games Played Yet.");
        }

        foreach (var game in gamesPlayed)
        {
            Console.WriteLine($"{game.Date} - {game.Type} Game: Score = {game.Score} out of {game.Rounds} points");
        }

        Console.WriteLine("----------------------------------------------------\n");
        Console.WriteLine("Type any key to continue.");
        Console.ReadKey();
    }

    internal static int[] GetFirstAndSecondNumber(Difficulty difficulty)
    {
        var random = new Random();
        var result = new int[2];

        if (difficulty == Difficulty.Beginner)
        {
            var firstNumber = random.Next(1, 99);
            var secondNumber = random.Next(1, 99);

            result[0] = firstNumber;
            result[1] = secondNumber;

            return result;
        }
        else if (difficulty == Difficulty.Intermediate)
        {
            var firstNumber = random.Next(1, 199);
            var secondNumber = random.Next(1, 199);

            result[0] = firstNumber;
            result[1] = secondNumber;

            return result;
        }
        else if (difficulty == Difficulty.Advanced)
        {
            var firstNumber = random.Next(1, 299);
            var secondNumber = random.Next(1, 299);
            result[0] = firstNumber;
            result[1] = secondNumber;

            return result;
        }

        return result;
    }

    internal static int[] GetDivisionNumbers()
    {
        var random = new Random();
        var result = new int[2];
        var firstNumber = random.Next(1, 99);
        var secondNumber = random.Next(1, 99);

        while (firstNumber % secondNumber != 0)
        {
            firstNumber = random.Next(1, 99);
            secondNumber = random.Next(1, 99);
        }

        result[0] = firstNumber;
        result[1] = secondNumber;

        return result;
    }

    internal static void AddToHistory(int gameScore, int roundsPlayed, GameType gameType)
    {
        gamesPlayed.Add(new Game
        {
            Date = DateTime.Now,
            Score = gameScore,
            Rounds = roundsPlayed,
            Type = gameType
        });
    }

    internal static string? ValidateResults(string result)
    {
        while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
        {
            Console.WriteLine("Your answer needs to be an integer. try again.");
            result = Console.ReadLine();
        }

        return result;
    }

    internal static string GetName()
    {
        Console.WriteLine("Please type your name:");
        var name = Console.ReadLine();

        while (string.IsNullOrEmpty(name))
        {
            Console.WriteLine("Name cannot be empty. Try again.");
            name = Console.ReadLine();
        }

        return name;
    }
}