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
        foreach (var game in gamesPlayed)
        {
            Console.WriteLine($"{game.Date} - {game.Type} Game: Score = {game.Score} out of {game.Rounds} points");
        }

        Console.WriteLine("----------------------------------------------------\n");
        Console.WriteLine("Type any key to continue.");
        Console.ReadKey();
    }

    internal static int[] GetDivisionNumbers()
    {
        var random = new Random();
        var firstNumber = random.Next(1, 99);
        var secondNumber = random.Next(1, 99);
        var result = new int[2];

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
}